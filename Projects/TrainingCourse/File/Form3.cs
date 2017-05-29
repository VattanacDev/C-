using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = "Time:" + DateTime.Now.ToString("dd/MM/yyyy hh:mn:ss tt");
        }

        private void STUDENT_Click(object sender, EventArgs e)
        {
            Form5 objFrm = new Form5();
            OpenSubForm(objFrm);

        }

        private void USER_Click_1(object sender, EventArgs e)
        {
           Form1 objFrm = new Form1();
           OpenSubForm(objFrm);
           
        }
        void OpenSubForm(Form objFrm)
        {
            bool isAlreadyExist = false;
            foreach (Form frm in panelMain.Controls)
            {
                if (frm.Name==objFrm.Name)
                {
                    frm.BringToFront();
                    frm.Show();
                    isAlreadyExist = true;
                }
                
            }
            if (isAlreadyExist==false)
            {
                objFrm.TopLevel = false;
                objFrm.Parent = panelMain;
                objFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objFrm.WindowState = FormWindowState.Maximized;
                objFrm.Dock = DockStyle.Fill;
                objFrm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Left; 
                objFrm.Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
