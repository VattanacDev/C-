using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDownloader
{
    public partial class Form2 : Form
    {
        int PW;
        bool Hided;
        public Form2()
        {
            InitializeComponent();
            PW = panel2.Width;
            Hided = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Hided) button1.Text = "H\nI\nD\nE";
            else button1.Text="S\nH\nO\nW";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Hided)
            {
                panel2.Width = panel2.Width + 20;
                if (panel2.Width>=PW)
                {
                    timer1.Stop();
                    Hided=false;
                    this.Refresh();
                }
            }
            else
            {
                panel2.Width = panel2.Width - 20;
                if (panel2.Width<=0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }
    }
}
