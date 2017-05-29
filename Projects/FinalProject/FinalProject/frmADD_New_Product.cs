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
    public partial class frmADD_New_Product : Form
    {
        public frmADD_New_Product()
        {
            InitializeComponent();
        }
        string path = "./mySource.txt";
        string pal = "./backup.txt";
        string imagePath = "./FPictures/ ";
        List<Product> source = new List<Product>();
        List<Product> sourceBIN = new List<Product>();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectIndex = lstShowInfo.SelectedIndices[0];
            Product pro = source[selectIndex];
            File.Delete(imagePath + pro.ImageName);
            sourceBIN.Add(pro);
            source.RemoveAt(selectIndex);

            StreamWriter writerBIN = new StreamWriter(pal);
            foreach (Product itemBIN in source)
            {
                writerBIN.WriteLine(itemBIN.GetInfo());

            }
            writerBIN.Close();
            ReadProductToSource();
            ReadSourceToListView();

            StreamWriter writer = new StreamWriter(path);
            foreach (Product item in source)
            {
                writer.WriteLine(item.GetInfo());

            }
            writer.Close();
            ReadProductToSource();
            ReadSourceToListView();
        }

      void WriterProduct(Product pro)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(pro.GetInfo());
            writer.Close();
            if (pictureBox1.ImageLocation!=null)
            {
                string DestenationPath = imagePath + pro.ImageName;
                File.Copy(pictureBox1.ImageLocation, DestenationPath);
            }
        }
      double total = 0;
     void ReadProductToSource()
      {
          source.Clear();
          if (File.Exists(path) == false) return;
          StreamReader read = new StreamReader(path);
          string values = read.ReadToEnd();
          read.Close();
          MessageBox.Show(values);
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

          //  product.ID = txtID.Text;
          //  product.Name = txtName.Text;
          //  product.Qty = float.Parse(txtQty.Text);
          //  product.Price = float.Parse(txtPrice.Text);
          //  product.Type = cmbType.Text;
          //  product.ImageName = pictureBox1.Image.ToString();
              
              source.Add(product);
              total += product.Amount;
              lblTotal.Text = total.ToString();
          }
      }
     
    void ReadSourceToListView()
     {
         imageList32x32.Images.Clear();
         imageList64x64.Images.Clear();
         lstShowInfo.Items.Clear();

         lstShowInfo.Items.Clear();
         foreach (Product pro in source)
         {
             string imgpath = imagePath + pro.ImageName;
             if (File.Exists(imgpath)==true)
             {
                 Image image = Image.FromFile(imgpath);
                 imageList32x32.Images.Add(pro.ID, image);
                 imageList64x64.Images.Add(pro.ID, image);
                 image.Dispose();

             }
             ListViewItem item = new ListViewItem();
             item.ImageKey = pro.ID;
             item.Text = pro.ID;
             item.SubItems.Add(pro.Name);
             item.SubItems.Add(pro.Type);
             item.SubItems.Add(pro.Qty.ToString());
             item.SubItems.Add(pro.Price.ToString());
             item.SubItems.Add(pro.Amount.ToString());
             lstShowInfo.Items.Add(item);

         }
     }

    private void lblTotal_Click(object sender, EventArgs e)
    {

    }

    private void btnADD_Click(object sender, EventArgs e)
    {
        Product pro = new Product();
        pro.ID = txtID.Text;
        pro.Name = txtName.Text;
        pro.Qty = float.Parse(txtQty.Text);
        pro.Price = float.Parse(txtPrice.Text);
        pro.Type = cmbType.Text;
        pro.Picture = pictureBox1.Image;
        pro.ImageName = Guid.NewGuid() + Path.GetExtension(pictureBox1.ImageLocation);

        WriterProduct(pro);

        ReadProductToSource();
        ReadSourceToListView();
        ClearTextControl();

    }
    void ClearTextControl()
    {
        btnADD.Enabled = true;
        btnDelete.Enabled = true;
        btnEDite.Enabled = false;

        txtID.Clear();
        txtName.Clear();
        txtPrice.Clear();
        txtQty.Clear();
        pictureBox1.ImageLocation = null;
        cmbType.SelectedIndex = -1;
        txtID.Focus();
    }

    private void pictureBox1_DoubleClick(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog()== System.Windows.Forms.DialogResult.OK)
        {
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }

    private void frmADD_New_Product_Load(object sender, EventArgs e)
    {
        ReadProductToSource();
        ReadSourceToListView();
    }
    int updateIndex = 0;
    private void btnEDite_Click(object sender, EventArgs e)
    {
        Product pro = source[updateIndex];
        if (pictureBox1.ImageLocation!=imagePath+pro.ImageName)
        {
            File.Copy(pictureBox1.ImageLocation, imagePath + pro.ImageName, true);
        }
        source[updateIndex].ID = txtID.Text;
        source[updateIndex].Name = txtName.Text;
        source[updateIndex].Type = cmbType.Text;
        source[updateIndex].Qty = float.Parse(txtQty.Text);
        source[updateIndex].Price =float.Parse( txtPrice.Text);

        updateProduct();
        ReadProductToSource();
        ReadSourceToListView();
        ClearTextControl();

    }
    void updateProduct()
    {
        StreamWriter write = new StreamWriter(path, false);
        foreach (Product pro in source)
        {
            write.WriteLine(pro.GetInfo());

        }
        write.Close();
    }
    private void lstShowInfo_DoubleClick(object sender, EventArgs e)
    {
        updateIndex = lstShowInfo.SelectedIndices[0];
        Product pro = source[updateIndex];
        txtID.Text = pro.ID;
        txtName.Text = pro.Name;
        cmbType.Text = pro.Type;
        txtQty.Text = pro.Qty.ToString();
        txtPrice.Text = pro.Price.ToString();
        pictureBox1.ImageLocation = imagePath + pro.ImageName;

        btnADD.Enabled = false;
        btnDelete.Enabled = false;
        btnEDite.Enabled = true;

    }
    private void btnNew_Click(object sender, EventArgs e)
    {
        ClearTextControl();
    }



  



    }
   
}

////////
