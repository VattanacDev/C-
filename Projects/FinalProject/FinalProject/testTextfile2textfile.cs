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
namespace FinalProject
{
    public partial class testTextfile2textfile : Form
    {
        public testTextfile2textfile()
        {
            InitializeComponent();
        }
    string path1 = "./File1.txt";
    string path2 = "./File2.txt";
    string path3 = "./File3.txt";
     private void button1_Click(object sender, EventArgs e)
        {
          
              File.WriteAllText(path1, "test1");

               // Write to local file 2.
               File.WriteAllText(path2, "test2");
             
               // Replace contents of file 1 with contents of file 2.
               // ... Also create file 3 as backup.
               File.Replace(path2, path1, path3);
    }

     private void button2_Click(object sender, EventArgs e)
     {
         File.Delete(path1);
         MessageBox.Show("path1 have delet");
     }

        }
    }

