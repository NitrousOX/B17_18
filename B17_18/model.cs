using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B17_18
{
    public partial class model : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B17_18;Integrated Security=True");
        public model()
        {
            SqlCommand proiz = new SqlCommand("select * from Proizvodjac order by ProizvodjacID", conn);
            SqlCommand model = new SqlCommand("select * from Model order by ModelID",conn);
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            radioButton3.Checked = true;

            conn.Open();
            SqlDataReader rd = proiz.ExecuteReader();
            while(rd.Read())
            {
                comboBox1.Items.Add(rd.GetInt32(0).ToString() + "-" + rd.GetString(1));
            }
            conn.Close();

            conn.Open();
            SqlDataReader rd1 = model.ExecuteReader();
            while (rd1.Read())
            {
                comboBox2.Items.Add(rd1.GetInt32(0).ToString() + "-" + rd1.GetString(1));
            }
            conn.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string t1 = null, and1 = null, and2 = null;
                string t2 = null;
                string t3 = null;
                string where = " where ";

                if (comboBox1.Text != "Sve")
                {
                    t1 = " Proizvodjac.ProizvodjacID = @p1";
                }
                else { t1 = ""; }

                if (comboBox2.Text != "Sve")
                {
                    t2 = " Model.ModelID = @p2 ";
                    if (t1 != "")
                    { and1 = " and "; }
                    else { and1 = ""; }
                }
                else { t2 = ""; }

                if (radioButton1.Checked)
                {
                    t3 = " DatumZavrsetka < @p3";
                    if (t2 != "" || t1 != "")
                    { and2 = " and "; }
                    else { and2 = ""; }
                }
                if (radioButton2.Checked)
                {
                    t3 = " DatumZavrsetka > @p3 ";
                    if (t2 != "" || t1!="")
                    { and2 = " and "; }
                    else { and2 = ""; }
                }
                if (radioButton3.Checked)
                {
                    t3 = "";
                }
                if (t1 == "" && t2 == "" && t3 == "")
                    where = "";

                string komanda = "select Vozac.VozacID, Vozac.Ime, Vozac.Prezime, Vozilo.RegistarskiBroj, Polisa.PolisaID , Polisa.DatumPocetka,Polisa.DatumZavrsetka from Vozac join Vozilo_Vozac on Vozac.VozacID = Vozilo_Vozac.VozacID join Vozilo on Vozilo.VoziloID = Vozilo_Vozac.VoziloID join Polisa on Polisa.PolisaID = Vozilo.PolisaID join Proizvodjac on Proizvodjac.ProizvodjacID = Vozilo.ProizvodjacID join Model on Model.ModelID = Vozilo.ModelID" + where + t1 + and1 + t2 + and2 + t3;
                SqlCommand select = new SqlCommand(komanda, conn);

                if(t1!="")
                {
                    select.Parameters.AddWithValue("@p1", comboBox1.Text.Split('-')[0]);
                }
                if (t2!="")
                {
                    select.Parameters.AddWithValue("@p2", comboBox2.Text.Split('-')[0]);
                }
               if(t3!="")
                {
                    select.Parameters.AddWithValue("@p3", DateTime.Now);
                }


                DataSet ds = new DataSet();
                
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(select);
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
