using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace File
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if(result==System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter writer=new StreamWriter(saveFileDialog1.FileName);
                writer.WriteLine(txtInput.Text+"|"+txtMessage.Text);
                writer.Close();
                txtMessage.Clear();
                txtInput.Clear();
                
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result==System.Windows.Forms.DialogResult.OK)
	        {
		       StreamReader reader=new StreamReader(openFileDialog1.FileName);
                string value=reader.ReadToEnd();
                reader.Close();

                string[] source=value.Split('|');
                txtInput.Text=source[0];
                txtMessage.Text=source[1];
          	}
        }



    }
}
