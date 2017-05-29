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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string msg)
        {//Contructor
            MessageBox.Show(msg);
        }
        int sum2(ref int a,int b)
        {
            a = 100;
            return a + b;
        }
        private void btnRef_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            sum2(ref a, b);
            MessageBox.Show(a.ToString());
        }
        void S(int a,int b,out int result)
        {
            result = a + b;
        }
        private void btnOUt_Click(object sender, EventArgs e)
        {
            int result;
            S(20, 10, out result);
            MessageBox.Show(result.ToString());

        }
       // private void btnParams_Click(object sender, EventArgs e)
        private void btnParams_Click(object sender, EventArgs e)
        {
            int[] i = { 1,2,3,4,5};
            int result = sum(i);
           // int result = sum(20,30);
            MessageBox.Show(result.ToString());

        }
        int sum(params int[] value)
        {
            int total = 0;
            foreach (int item in value)
            {
                total += item;
            }
            return total;
        }

        private void Default_Click(object sender, EventArgs e)
        {
          float result=sum(6,8);
               
        }
        float sum(int a=0,int b=0)
        {
            return a+b;
        }

        private void Recursive_Click(object sender, EventArgs e)
        {
            float result = Fac(4);
            MessageBox.Show(result.ToString());
        }
        float Fac(int n)
        {
            float result = 0;
            if (n == 1) return 1;
            else
            {
                result = n * Fac(n - 1);
            }
            return result;
        }
          
        private void Contructor_Click(object sender, EventArgs e)
        {
            new Form2("Hello World");///Constructor
        }

    
    }
}
