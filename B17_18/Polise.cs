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
    public partial class Polise : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B17_18;Integrated Security=True");
        List<int> id = new List<int>();
        public Polise()
        { 
            InitializeComponent();
            Ucitaj();
        }
        private void Ucitaj()
        {
            SqlCommand ucitaj = new SqlCommand("select PolisaID from Polisa order by PolisaID", conn);
            conn.Open();
            SqlDataReader rd = ucitaj.ExecuteReader();
            comboBox1.Items.Clear();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd.GetInt32(0).ToString());
                id.Add(rd.GetInt32(0)); 
            }
            conn.Close();
            comboBox1.SelectedIndex = 0;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Upisi_btn_Click(object sender, EventArgs e)
        {
            SqlCommand Upis = new SqlCommand("insert into Polisa values(@p1,@p2,@p3,@p4)",conn);
            try
            {
                if (String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(textBox1.Text) || monthCalendar1.SelectionStart == null || monthCalendar2.SelectionStart == null)
                    throw new Exception("Morate sve uneti");

                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (!Char.IsDigit(textBox1.Text[i]))
                    {
                        textBox1.Text = null;
                        throw new Exception("Mora biti pozitivan ceo broj");
                    }
                }

                Upis.Parameters.AddWithValue("@p1",Convert.ToInt32(comboBox1.Text));
                Upis.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart);
                Upis.Parameters.AddWithValue("@p3", monthCalendar2.SelectionStart);
                Upis.Parameters.AddWithValue("@p4", Convert.ToInt32(textBox1.Text));

                conn.Open();
                Upis.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste upisali");
                conn.Close();
                Ucitaj();

            }
            catch(SqlException ex) {if(ex.Number==2627) MessageBox.Show("vec postoji"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        private void Obriis_btn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            SqlCommand Brisanje = new SqlCommand("delete from Polisa where PolisaID= @p1;",conn);
            try
            {
                if (String.IsNullOrEmpty(comboBox1.Text))
                    throw new Exception("izaberite id");
                foreach (int elem in id)
                {
                    if (elem == Convert.ToInt32(comboBox1.Text))
                        flag = true;
                }
                if (!flag)
                    throw new Exception("Ne postoji");

                Brisanje.Parameters.AddWithValue("@p1", Convert.ToInt32(comboBox1.Text));
                conn.Open();
                Brisanje.ExecuteNonQuery();
                MessageBox.Show("Uspesno obrisan");
                conn.Close();
                Ucitaj();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
            finally { conn.Close(); }
        }

        private void Izmeni_btn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            SqlCommand Izmena = new SqlCommand("update Polisa set DatumPocetka =@p2, DatumZavrsetka=@p3, Vrednost =@p4 where PolisaID =@p1", conn);
            try
            {
                if (String.IsNullOrEmpty(comboBox1.Text))
                    throw new Exception("izaberite id");
                foreach (int elem in id)
                {
                    if (elem == Convert.ToInt32(comboBox1.Text))
                        flag = true;
                }
                if (!flag)
                    throw new Exception("Ne postoji");

                Izmena.Parameters.AddWithValue("@p1", Convert.ToInt32(comboBox1.Text));
                Izmena.Parameters.AddWithValue("@p2", monthCalendar1.SelectionStart);
                Izmena.Parameters.AddWithValue("@p3", monthCalendar2.SelectionStart);
                Izmena.Parameters.AddWithValue("@p4", Convert.ToInt32(textBox1.Text));
                conn.Open();
                Izmena.ExecuteNonQuery();
                MessageBox.Show("Uspesno izmenili");
                conn.Close();
                Ucitaj();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }
    }
}
