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
    public partial class Equation2Degree : Form
    {
        public Equation2Degree()
        {
            InitializeComponent();
        }

       double delta(float a,float b,float c)
        {
            float result = b * b - 4 * a * c;
            return result;
        }
      
        private void btnCalculate_Click(object sender, EventArgs e)
        {
           //i²;
           // const int  i²=1;
            //Math.sqrt(i²);
            float a=float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);
            double X1,X2;
           double result= delta(a, b, c);
          
           if (result<0)
           {
             //  result = result
               MessageBox.Show("គ្មានឬស"); 
           }
           else if(result>=0)
           {

               X1 = (-b + Math.Sqrt(result))/2*a;
               X2 =  (-b - Math.Sqrt(result))/2*a;
               lblX1.Text = X1.ToString();
               lblX2.Text = X2.ToString();
           }
          /* else if (result==0)
           {
               X1 = -b + Math.Sqrt(result);
               X2 = -b + Math.Sqrt(result);
               X1 = X2;
               lblX1.Text = lblX2.Text =X1.ToString();
           }
          */

        }
    }
}
