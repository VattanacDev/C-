using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClassBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.ID = "BK001";
            book.Title = "Khmer";
            book.Author = "KOK";
            book.PublishDate = new DateTime(1995,04,10);
            
            string info=book.GetInfo();
            label1.Text = info;
           // MessageBox.Show(info);
            
        }

        private void Product_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            products.ID = "P001";
            products.Name = "Rice";
            products.Price = 2;
            products.Qty = 5;
            float re=  products.Amount;

            string info = products.GetInfo();
            label1.Text = info;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // S=PI*R*R
            //P=2*PI*R
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Id = 1;
            s.FirstName = "Sok";
            s.LastName = "Kosal";
            s.Gender = "Male";
            s.grade = "A";
            s.subject = "C#";
            s.DateBirth = new DateTime(1998, 04, 21);
            string result = s.getInfo();
            label1.Text=result;
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            Student p = new Student();
           p.Id = 1;
           p.FirstName = "Men";
           p.LastName = "Kaknika";
           p.Gender = "Female";
           p.DateBirth = new DateTime(1998,4,1);
            string result = p.getInfo();
            label1.Text = result;
        }
    }
}
