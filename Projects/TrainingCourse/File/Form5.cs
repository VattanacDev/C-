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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string path = "./mySource.txt";
        string imagePath = "./Pictures/ ";
        List<Student> source = new List<Student>();

        void WritStudent(Student stu)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(stu.GetInfo());
            writer.Close();
            if (pictureBox1.ImageLocation != null)
             {
                string DestenationPath = imagePath + stu.ImageName;
                System.IO.File.Copy(pictureBox1.ImageLocation, DestenationPath);
             }
            }

        void ReadStudentToSource()
        {
           /* //List<Student> studentList = new List<Student>();
           
            StreamReader read = new StreamReader(path);
            string source = read.ReadToEnd();
            read.Close();
            string[] stus = source.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in stus)
            {
                string[] infos = item.Split('|');
                Image image = Image.FromFile(imagePath + infos[0] + infos[3]);
                imageList32x32.Images.Add(infos[0], image);
                imageList64x64.Images.Add(infos[0], image);

                Student student = new Student();
                student.ID = infos[0];
                student.Name = infos[1];
                student.Gender = infos[2];
                student.Picture = image;
                student. ImageName = infos[3];
                studentList.Add(student);

                image.Dispose();
            }
          //  return studentList;
           **/
            source.Clear();
            if (System.IO.File.Exists(path) == false) return;
            StreamReader read = new StreamReader(path);
            string values = read.ReadToEnd();
            read.Close();

            string[] stus = values.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string  item in stus)
            {
                string[] infos = item.Split('|');

                Student student = new Student();
                student.ID=infos[0];
                student.Name = infos[1];
                student.Gender = infos[2];
                student.ImageName = infos[3];
                source.Add(student);
            }
        }

        void ReadSourceToListViiew()
        {
            imageList32x32.Images.Clear();
            imageList64x64.Images.Clear();
            listView1.Items.Clear();


            listView1.Items.Clear();
            foreach ( Student stu in source)
            {
                string imgpath = imagePath + stu.ImageName;
                if (System.IO.File.Exists(imgpath) == true)
                 {
                    Image image = Image.FromFile(imgpath);
                    imageList32x32.Images.Add(stu.ID, image);
                    imageList64x64.Images.Add(stu.ID, image);
                    image.Dispose();
                  }
                ListViewItem item=new ListViewItem();
                item.ImageKey=stu.ID;
                item.Text = stu.ID;
                item.SubItems.Add(stu.Name);
                item.SubItems.Add(stu.Gender);
                listView1.Items.Add(item);

            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.ID = txtID.Text;
            stu.Name = txtName.Text;
            stu.Gender = comboBox1.Text;
            stu.Picture = pictureBox1.Image;
            stu.ImageName = Guid.NewGuid() + Path.GetExtension(pictureBox1.ImageLocation);
            // stu. ImageName = Path.GetExtension(pictureBox1.ImageLocation);
            WritStudent(stu);

            //source = ReadStudent();
            ReadStudentToSource();
            ReadSourceToListViiew();
            ClearTextControl();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ReadStudentToSource();
            ReadSourceToListViiew();
       
        }
        void ClearTextControl()
        {
            buttonADD.Enabled = true;
            buttonDelete.Enabled = true;
            buttonEDite.Enabled = false;

            txtID.Clear();
            txtName.Clear();
            pictureBox1.ImageLocation = null;
            comboBox1.SelectedIndex = -1;
            txtID.Focus();
        }

        private void buttonEDite_Click(object sender, EventArgs e)
        {
            Student stu = source[updateIndex];
            if(pictureBox1.ImageLocation!=imagePath+stu.ImageName)
            {
                System.IO.File.Copy(pictureBox1.ImageLocation, imagePath + stu.ImageName, true);
            }
            source[updateIndex].ID = txtID.Text;
            source[updateIndex].Name = txtName.Text;
            source[updateIndex].Gender = comboBox1.Text;
            updatStudent();
            ReadStudentToSource();
            ReadSourceToListViiew();
            ClearTextControl();
        }

       void  updatStudent()
        {
            StreamWriter write = new StreamWriter(path,false);
            foreach (Student stu in source)
            {
                write.WriteLine(stu.GetInfo());
                
            }
            write.Close();
        }
        int updateIndex = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            updateIndex = listView1.SelectedIndices[0];
            Student stu = source[updateIndex];
            txtID.Text = stu.ID;
            txtName.Text = stu.Name;
            comboBox1.Text = stu.Gender;
            pictureBox1.ImageLocation = imagePath + stu.ImageName;

            buttonADD.Enabled = false;
            buttonDelete.Enabled = false;
            buttonEDite.Enabled = true;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectIndex = listView1.SelectedIndices[0];
            Student stu = source[selectIndex];
            System.IO.File.Delete(imagePath + stu.ImageName);
            source.RemoveAt(selectIndex);

            StreamWriter writer = new StreamWriter(path);
            foreach (Student item in source)
            {
                writer.WriteLine(item.GetInfo());

            }
            writer.Close();

            ReadStudentToSource();
            ReadSourceToListViiew();
            ClearTextControl();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearchc_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            imageList32x32.Images.Clear();
            imageList64x64.Images.Clear();
            var stus = source.OrderBy(s => s.ID);
            foreach (Student item in stus)
            {
                if (item.ID.ToLower().StartsWith(txtSearchc.Text.ToLower())||item.Name.ToLower().StartsWith(txtSearchc.Text.ToLower()))
                {
                    if (System.IO.File.Exists(imagePath + item.ImageName))
                     {
                        Image img = Image.FromFile(imagePath + item.ImageName);
                        imageList32x32.Images.Add(item.ID, img);
                        imageList64x64.Images.Add(item.ID, img);
                        img.Dispose();
                     }
                    ListViewItem row = new ListViewItem();
                    row.ImageKey = item.ID;
                    row.Text = item.ID;
                    row.SubItems.Add(item.Name);
                    row.SubItems.Add(item.Gender);

                    listView1.Items.Add(row);
                }
            }
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        



    }
}
