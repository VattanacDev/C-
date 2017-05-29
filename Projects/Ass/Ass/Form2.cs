using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace Ass
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string Encrypt(string value)
        {
            using(MD5CryptoServiceProvider md5=new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
       
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(mtxtPass.Text))
            {
                MessageBox.Show("Please Enter Your PassWord", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            mtxtResult.Text = Encrypt(mtxtPass.Text);

        }




        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
