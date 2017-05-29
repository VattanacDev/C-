using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float val1 = float.Parse(txtValue1.Text);
            float val2 = float.Parse(txtValue2.Text);
            float result = Sum(val1, val2, '%');
            MessageBox.Show(result.ToString());
        }
        float Sum(float a,float b,char oper)
        {

            float total=0;
            switch(oper)
            {
                case '+': total = a + b; break;
                case '-': total = a - b; break;
                case '*': total = a * b; break;
                case '/': total = a / b; break;
                case '%': total = a % b; break;


            } return total;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            float val1 = float.Parse(txtValue1.Text);
            float val2 = float.Parse(txtValue2.Text);
            float result = Sum(val1,val2,'+');
            MessageBox.Show(result.ToString());
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            float val1 = float.Parse(txtValue1.Text);
            float val2 = float.Parse(txtValue2.Text);
            float result = Sum(val1, val2, '-');
            MessageBox.Show(result.ToString());
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            float val1 = float.Parse(txtValue1.Text);
            float val2 = float.Parse(txtValue2.Text);
            float result = Sum(val1, val2, '*');
            MessageBox.Show(result.ToString());
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            float val1 = float.Parse(txtValue1.Text);
            float val2 = float.Parse(txtValue2.Text);
            float result = Sum(val1, val2, '/');
            MessageBox.Show(result.ToString());
        }
    }
}
