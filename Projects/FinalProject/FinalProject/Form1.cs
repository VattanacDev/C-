using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           Thread t = new Thread(new ThreadStart(StartForm));
           t.Start();
           Thread.Sleep(5000);
           InitializeComponent();
           t.Abort();

          
        }
        public void StartForm()
        {
            Application.Run(new frmSplashSreen());
        }
       private void Form1_Load(object sender, EventArgs e)
        {
         
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Time:" + DateTime.Now.ToString("dd/MM/yyy hh:mm:ss tt");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmADD_New_Product frmAddProduct = new frmADD_New_Product();
            OpenSubForm(frmAddProduct);
        }

        void OpenSubForm(Form objFrm)
        {
            bool isAlreadyExist = false;
            foreach (Form frm in pnlMain.Controls)
            {
                if (frm.Name == objFrm.Name)
                {
                    frm.BringToFront();
                    frm.Show();
                    isAlreadyExist = true;
                }

            }
            if (isAlreadyExist == false)
            {
                objFrm.TopLevel = false;
                objFrm.Parent = pnlMain;
                objFrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objFrm.WindowState = FormWindowState.Maximized;
                objFrm.Dock = DockStyle.Fill;
                objFrm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Left;
                objFrm.Show();
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            frmData frmdata = new frmData();

        }
    }
}
