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
    public partial class frmOnlyDigitonTrxtBoxcs : Form
    {
        public frmOnlyDigitonTrxtBoxcs()
        {
            InitializeComponent();
        }

       

      
    /* int fraction(int a, int b)
        {
            int A, B,final=0;
            for (int i = 2; i <= 9;i++ )
            {
               
                if (a % i == 0 && b % i == 0)
                {
                    
                    A = a / i;
                    B = b / i;
                   final= fraction(A, B);
                   return fraction(A,B);

                }
               
             }
            return fraction;
     **/
        string sim(int a,int b)
        {
            string result = a + "/" + b;
            for (int i = 2; i <= 9;i++ )
            {
                int c = a % i;
                int d = b % i;
                if(c==0&&d==0)
                {
                    c = a / i;
                    d=b / i;
                    result = sim(c, d);
                    break;
                }
                
            }
            return result;
        }
    

     private void button1_Click(object sender, EventArgs e)
     {
         string result = sim(9,81);
        MessageBox.Show(result);
     }

     private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
     {
         controlTextBox(txtInput, e);
     }

 void controlTextBox(TextBox textbox,KeyPressEventArgs e)
     {
         if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '.' && e.KeyChar != '\b') e.Handled = true;
         if (textbox.Text == "0" && e.KeyChar!='.' && char.IsDigit(e.KeyChar) == true) textbox.Text ="";
          int i = textbox.Text.IndexOf('.');
         if (i >= 0 && e.KeyChar == '.') e.Handled = true;
         if (textbox.Text == "" && e.KeyChar == '.') e.Handled = true;
     }

 private void txtInput_TextChanged(object sender, EventArgs e)
 {
    
 }

      string Convert(string value)
 {
     string result = value
                        .Replace('១', '1')
                        .Replace('២', '2')
                        .Replace('៣', '3')
                        .Replace('៤', '4')
                        .Replace('៥', '5')
                        .Replace('៦', '6')
                        .Replace('៧', '7')
                        .Replace('៨', '8')
                        .Replace('៩', '9')
                        .Replace('០', '0');
     return result;



 }

      private void txt2_KeyPress(object sender, KeyPressEventArgs e)
      {
         
      }

      private void button2_Click(object sender, EventArgs e)
      {
         // MessageBox.Show(Convert("១២៣៤៥៦៧៨៩០"));
          label1.Text = Convert(txt2.Text);
      }




    }
}
