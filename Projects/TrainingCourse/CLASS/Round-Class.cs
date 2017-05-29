using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASS
{
    public partial class Round_Class : Form
    {
        public Round_Class()
        {
            InitializeComponent();
        }

        private void radioS_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            RoundCal All = new RoundCal();
            
            float k = float.Parse(txtInput.Text);
            All.R = k;
            if (radioS.Checked == true)
            {
                double result = All.S(k);
                lblShow.Text = result.ToString();
            }
             if (radioP.Checked==true)
            {
                double result = All.P(k);
                lblShow.Text = result.ToString();
                
            }
        }

        private void btnCal_MouseLeave(object sender, EventArgs e)
        {
            lblShow.Text = "";
        }

        private void btnCal_MouseHover(object sender, EventArgs e)
        {
            RoundCal All = new RoundCal();
            if (txtInput.Text == null) return;
            float k = float.Parse(txtInput.Text);
            All.R= k;
            if (radioS.Checked == true&&txtInput.Text!=null)
            {
                double result = All.S(k);
                lblShow.Text = result.ToString();
            }
            if (radioP.Checked == true&&txtInput.Text!=null)
            {
                double result = All.P(k);
                lblShow.Text = result.ToString();

            }
            
        }
    }
}
