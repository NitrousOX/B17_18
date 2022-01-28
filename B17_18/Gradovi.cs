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
    public partial class Gradovi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B17_18;Integrated Security=True");
        bool postoji = false;
        public Gradovi()
        {
            SqlCommand Ucitavanje = new SqlCommand("select GradID from Grad", conn);
            InitializeComponent();

            conn.Open();
            SqlDataReader rd = Ucitavanje.ExecuteReader();
            while(rd.Read())
            {
                comboBox1.Items.Add(rd.GetInt32(0).ToString());
            }
            conn.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_TextUpdate(object sender, EventArgs e)
        {
            SqlCommand provera = new SqlCommand("select * from Grad where GradID = @p1",conn);
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                try
                {
                    for(int i =0; i<comboBox1.Text.Length; i++)
                    {
                        if (!Char.IsDigit(comboBox1.Text[i]))
                        {
                            postoji = false;
                            throw new Exception("Morate broj uneti");
                        }
                    }

                    conn.Open();
                    provera.Parameters.AddWithValue("@p1",Convert.ToInt32(comboBox1.Text));
                    SqlDataReader rd = provera.ExecuteReader();

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            textBox1.Text = rd.GetString(1);
                            textBox2.Text = rd.GetString(2);
                            textBox3.Text = rd.GetInt32(3).ToString();
                            textBox4.Text = rd.GetInt32(4).ToString();
                            postoji = true;
                        }
                    }
                    else {
                        textBox1.Text = null;
                        textBox2.Text = null;
                        textBox3.Text = null;
                        textBox4.Text = null;
                        postoji = false;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }
            }
            else
            {
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null; 
                postoji = false;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            SqlCommand provera = new SqlCommand("select PozivniBroj from Grad where PostanskiBroj = @p1", conn);
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                try
                {
                    for (int i = 0; i < textBox2.Text.Length; i++)
                    {
                        if (!Char.IsDigit(textBox2.Text[i]))
                        {
                            throw new Exception("Morate broj uneti");
                        }
                    }

                    conn.Open();
                    provera.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox2.Text));
                    SqlDataReader rd = provera.ExecuteReader();

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            textBox3.Text = rd.GetString(0);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Obrisibtn_Click(object sender, EventArgs e)
        {

        }

        private void Izmenibtn_Click(object sender, EventArgs e)
        {

        }
    }
}
