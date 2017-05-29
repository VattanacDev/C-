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
    public partial class Rechtangle : Form
    {
        public Rechtangle()
        {
            InitializeComponent();
        }
       
        float Area(float a,float b)
        {
            float result = a * b;
            return result;
        }
        float P(float a,float b)
        {
            float result = 2*(a + b);
            return result;
        }

        private void btnCalcu_Click(object sender, EventArgs e)
        {

            float Height = float.Parse(txtHeight.Text);
            float Width = float.Parse(txtWidth.Text);
            
           if (rdPtey.Checked == true)
           {
               lblResult.Text = "";
             if (Width > Height)
               {
                   float final = Area(Height, Width);
                   lblResult.Text = final.ToString();
                   
               }
             else
               MessageBox.Show("បណ្តោយត្រូវធំជាងទទឹង","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else if (rdPakrimart.Checked== true)
           {
             
               if (Width > Height)
               {
                   lblResult.Text = "";
                    float final = P(Height, Width);
                    lblResult.Text = final.ToString();
                }
               else
                   MessageBox.Show("បណ្តោយត្រូវធំជាងទទឹង", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        

            
        }

        private void rdPtey_MouseLeave(object sender, EventArgs e)
        {
            lblResult.Text="";
        }
    }
}
