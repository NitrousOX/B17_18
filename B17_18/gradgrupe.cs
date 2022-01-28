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
    public partial class gradgrupe : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B17_18;Integrated Security=True");
        public gradgrupe()
        {
            SqlCommand grupa = new SqlCommand("select GrupaID, Naziv from Osiguravajuca_Grupa order by GrupaID",conn);
            SqlCommand grad = new SqlCommand("select Grad from Grad order by Grad",conn);
            InitializeComponent();
            conn.Open();
            SqlDataReader rd = grupa.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd.GetInt32(0).ToString() + ":" + rd.GetString(1));
            }
            conn.Close();

            conn.Open();
            SqlDataReader rd1 = grad.ExecuteReader();
            while (rd1.Read())
            {
                comboBox2.Items.Add(rd1.GetString(0));
            }
            conn.Close();

            comboBox1.Items.Add("Svi");
            comboBox2.Items.Add("Svi");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
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
                if (t2 != "" || t1 != "")
                { and2 = " and "; }
                else { and2 = ""; }
            }
            if (radioButton3.Checked)
            {
                t3 = "";
            }
            if (t1 == "" && t2 == "" && t3 == "")
                where = "";
            string komanda = @"select Vozac.VozacID,Vozac.Ime,Vozac.Prezime,Vozilo.RegistarskiBroj,Polisa.PolisaID,Polisa.DatumPocetka,Polisa.DatumZavrsetka 
from Vozac join Vozilo_Vozac on Vozac.VozacID = Vozilo_Vozac.VozacID join Vozilo on Vozilo.VoziloID = Vozilo_Vozac.VoziloID join Polisa on Polisa.PolisaID = Vozilo.PolisaID";
           
        }
    }
}
