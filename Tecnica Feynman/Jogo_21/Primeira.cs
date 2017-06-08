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
    public partial class Primeira : Form
    {
        int min = 0, seg = 0;


        public Primeira()
        {
            InitializeComponent();
        }

        // chamar dashboard
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var dash = new Dashboard();
            dash.ShowDialog();
            //Application.Exit();
            Close();
        }

        // ao carregar a tela
        private void Primeira_Load(object sender, EventArgs e)
        {
            btnSeguir.Enabled = false;
            this.timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        // evento timer
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Start();
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }

            lblTempo.Text = min.ToString().PadLeft(2, '0') + ":" + seg.ToString().PadLeft(2, '0');

            if (seg == 5)
            {
                timer1.Stop();
                btnSeguir.Enabled = true;
            }
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            var seg = new Segunda();
            seg.ShowDialog();
            //Application.Exit();
            Close();
        }

        private void lblTempo_Click(object sender, EventArgs e)
        {

        }


    }
}
