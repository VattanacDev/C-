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
    public partial class frmData : Form
    {
        public frmData()
        {
            InitializeComponent();
        }
        string path = "./mySource.txt";
        string imagePath = "./FPictures/ ";
        List<Product> source = new List<Product>();
        double total = 0;  
        private void frmData_Load(object sender, EventArgs e)
        {
          
          source.Clear();
          if (File.Exists(path) == false) return;
          StreamReader read = new StreamReader(path);
          string values = read.ReadToEnd();
          read.Close();
          //MessageBox.Show(values);
          string[] pros = values.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
          foreach (string item in pros)
          {
               string[] infos=item.Split('|');
             
              Product product=new Product();
                      product.ID=infos[0];
                      product.Name = infos[1];
                      product.Type = infos[2];
                      product.Qty = float.Parse(infos[3]);
                      product.Price = float.Parse(infos[4]);
                      product.ImageName = infos[5];
                
                    
              source.Add(product);

              ListViewItem itemss= new ListViewItem();
                    itemss.Text=infos[0];
                    itemss.SubItems.Add(infos[1]);
                    itemss.SubItems.Add(infos[2]);
                    itemss.SubItems.Add(infos[3]);
                    itemss.SubItems.Add(infos[4]);
                    lstShowInfo.Items.Add(itemss);
                 //   itemss.SubItems.Add(float.Parse(infos[3])*float.Parse(infos[4]));
               
              total += product.Amount;
             
          }
      }
        }
    }

