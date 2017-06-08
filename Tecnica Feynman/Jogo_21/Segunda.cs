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
    public partial class Segunda : Form
    {

        int min = 0, seg = 0;

        public Segunda()
        {
            InitializeComponent();
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            var ter = new Terceira();
            ter.ShowDialog();
            //Application.Exit();
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var pri = new Primeira();
            pri.ShowDialog();
            //Application.Exit();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

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

        private void Segunda_Load(object sender, EventArgs e)
        {
            btnSeguir.Enabled = false;
            this.timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
