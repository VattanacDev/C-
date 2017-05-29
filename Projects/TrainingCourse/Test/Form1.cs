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
namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vattanac\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter sda = new
           SqlDataAdapter("Select Count(*) From Login Where Username='"+txtUserName.Text+"'and PassWord='"+txtPassWord.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {


                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("Please Check Your UserName and PassWord Again");
            }
        }

    }
}
