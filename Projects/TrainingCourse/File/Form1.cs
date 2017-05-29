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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath = @"G:\MyFile.txt";
        private void btnWrite_Click(object sender, EventArgs e)
        {
            StreamWriter writer=new StreamWriter(filePath,true);
            writer.WriteLine(textBox1.Text);
            writer.Close();

            textBox1.Clear();
            textBox1.Focus();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
           if(System.IO.File.Exists(filePath)==false )return;
            StreamReader reader=new StreamReader(filePath);
            string value=reader.ReadToEnd();
            reader.Close();

            char[] splitChar=new char[] {'\r','\n'};
            string [] source=value.Split(splitChar,StringSplitOptions.RemoveEmptyEntries);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(source);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
          int index=listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);

            StreamWriter writer=new StreamWriter(filePath,false);
            foreach (var item in listBox1.Items)
	        {
                writer.WriteLine(item.ToString());
		 
         	}
            writer.Close();
            btnRead.PerformClick();
        }
    }
}
