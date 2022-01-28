using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B17_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KrajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GradoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gradovi a = new Gradovi();
            a.Show();
        }

        private void ProizvodjacmodelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model a = new model();
            a.Show();
        }

        private void PoliseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Polise a = new Polise();
            a.Show();
        }

        private void GradovigrupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gradgrupe a = new gradgrupe();
            a.Show();
        }
    }
}
