using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_21
{
    public partial class Jogo21 : Form
    {
        int total = 0;

        public Jogo21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random numCarta = new Random();
            int x = numCarta.Next(1,14);
            this.label1.Text = Convert.ToString(x);
            this.listBox1.Items.Add("Carta (" + x + ")");
            total += x;
            this.label3.Text = Convert.ToString(total);

            if (total >= 21)
            {
                this.button1.Enabled = false;
                MessageBox.Show("PERDEEEEEEEUUUUUU KKKKKKKK!!!!");
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {            
            this.listBox1.Items.Clear();
            total = 0;
            this.label3.Text = "";
            this.label1.Text = "";
            this.button1.Enabled = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
