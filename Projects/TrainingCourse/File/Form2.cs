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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<string> source = new List<string>();
        int updateIndex = 0;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "choose Image(*.jpg;.*png,.gif)|.jpg;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            imageList32x32.Images.Add(txtName.Text, pictureBox1.Image);
            imageList64x64.Images.Add(txtName.Text, pictureBox1.Image);

            ListViewItem item = new ListViewItem();
            item.Text = txtName.Text; ;
            item.ImageKey = txtName.Text;
            item.SubItems.Add(cmbSatus.Text);
            item.SubItems.Add(txtTime.Text);
           
            lstInfo.Items.Add(item);
          


        }
        ImageList Imagelist = new ImageList();
        private void Form2_Load(object sender, EventArgs e)
        {


            /*   //retrieve all image files
               String[] ImageFiles = Directory.GetFiles(@"C:\test");
               foreach (var file in ImageFiles)
               {
                   //Add images to Imagelist
                   Imagelist.Images.Add(Image.FromFile(file));
               }
               //set the amall and large ImageList properties of listview
               lstInfo.LargeImageList = Imagelist;
               lstInfo.SmallImageList = Imagelist;

               lstInfo.Items.Add(new ListViewItem() { ImageIndex = 0});
           }
               }
             * */

        }

        public void poppulate()
        {
            ImageList imags = new ImageList();
            imags.ImageSize = new Size(50,50);
            string[] paths = { };
                paths=Directory.GetFiles("G:/Imgs");

            try
            {
                foreach (string path in paths)
                {
                    imags.Images.Add(Image.FromFile(path));
                }
            }catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            lstInfo.SmallImageList = imags;
            lstInfo.Items.Add("coca",0);
            lstInfo.Items.Add("coca", 1);
            lstInfo.Items.Add("coca", 2);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result==System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
