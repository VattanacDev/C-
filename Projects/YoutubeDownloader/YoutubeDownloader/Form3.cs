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
    public partial class Form3 : Form
    {
        int PW;
        bool Hiddd;
        public Form3()
        {
         
            InitializeComponent();
            PW = panel2.Width;
            Hiddd = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Hiddd) button1.Text = "H\nI\nD\nE";
            else button1.Text = "S\nH\nO\nW";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hiddd)
            {    panel2.Width+=20;
                if(panel2.Width>=PW)
                {
                    timer1.Stop();
                    Hiddd = false;
                    this.Refresh();
                }
                
            }
            else 
            {
                panel2.Width -= 20;
                if (panel2.Width<=0)
                {
                    timer1.Stop();
                    Hiddd = true;
                    this.Refresh();
                }
            }
        }
    }
}
