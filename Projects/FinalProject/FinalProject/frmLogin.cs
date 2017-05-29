using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FinalProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //txtPassWord.MaximumSize = 5;
            txtPassWord.UseSystemPasswordChar = true;
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vattanac\Documents\Data2.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='"+txtUserName.Text+"'and Password='"+txtPassWord.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {


                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                MessageBox.Show("please Check UserName and Password");     
            }
        }
        int passHide=0;
        private void lblSHoorHide_Click(object sender, EventArgs e)
        {
            if (passHide==0)
            {
                txtPassWord.UseSystemPasswordChar = false;
                passHide = 1;  
            }
            
            else if (passHide==1)
            {
              txtPassWord.UseSystemPasswordChar = true;
              passHide = 0;
            }
        }
    }
}
