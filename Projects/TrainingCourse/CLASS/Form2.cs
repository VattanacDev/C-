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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Product> source = new List<Product>();
        int updateRowIndex = 0;
        void ReadSourceTolistview()
        {
            listView1.Items.Clear();
            foreach (Product product in source)
            {
                ListViewItem item = new ListViewItem();
                item.Text = product.ID;
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.Price.ToString());
                item.SubItems.Add(product.Qty.ToString());
                item.SubItems.Add(product.Amount.ToString());
                listView1.Items.Add(item);
            }
        }
        void ClearTextControl()
        {
            textID.Clear();
            textName.Clear();
            textQty.Clear();
            textPrice.Clear();
            textID.Focus();
        }
        double total = 0;
        void AddProduct()
        {
            Product p = new Product();
            p.ID = textID.Text;
           
            p.Name = textName.Text;
            p.Qty = float.Parse(textQty.Text);
            p.Price = float.Parse(textPrice.Text);
            source.Add(p);
           
            
            total += p.Amount;
            labelTotal.Text = total.ToString();
;
            
        }
        void EnableButton(params Button[] buttons)
        {
            foreach (Button item in buttons)
            {
                item.Enabled = true;
            }
        }
        void DisableButton(params Button[] buttons)
        {
            foreach (Button item in buttons)
            {
                item.Enabled = false;
            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            AddProduct();
            ClearTextControl();
            ReadSourceTolistview();

           
        }

        private void buttonEDite_Click(object sender, EventArgs e)
        {
            if (buttonEDite.Text=="EDIT")
            {
                updateRowIndex = listView1.SelectedIndices[0];
                Product product = source[updateRowIndex];
                textID.Text = product.ID;
                textName.Text = product.Name;
                textQty.Text = product.Qty.ToString();
                textPrice.Text = product.Price.ToString();
                buttonEDite.Text="UPDATE";

                DisableButton(buttonDelete,buttonADD);
            }
            else if (buttonEDite.Text=="UPDATE")
            {
                source[updateRowIndex].ID = textID.Text;
                source[updateRowIndex].Name = textName.Text;
                source[updateRowIndex].Price = float.Parse(textPrice.Text);
                source[updateRowIndex].Qty = float.Parse(textQty.Text);
                updateRowIndex = 0;
                buttonEDite.Text = "EDIT";

                EnableButton(buttonDelete, buttonADD);
                ClearTextControl();
                ReadSourceTolistview();
            }
            labelTotal.Text = Total().ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.No)return;
          
            else
            {
                source.RemoveAt(listView1.SelectedIndices[0]);
                ReadSourceTolistview();
                labelTotal.Text = Total().ToString();
               // listView1.Items.Clear();
            }
      
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ClearTextControl();
           // buttonEDite.Text=
        }

        private void textBoxSearchc_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
                 //1 way
            /* var product = source.Where(pro => pro.ID.ToLower().StartsWith(textBoxSearchc.Text.ToLower()) || pro.Name.ToLower().StartsWith(textBoxSearchc.Text.ToLower()));


             foreach (Product item in product)
             {
                     ListViewItem item = new ListViewItem();
                     item.Text = product.ID;
                     item.SubItems.Add(product.Name);
                     item.SubItems.Add(product.Price.ToString());
                     item.SubItems.Add(product.Qty.ToString());
                     item.SubItems.Add(product.Amount.ToString());
                     listView1.Items.Add(item);
             }
             * */
            //2 way
          /*  source.Where(pro => pro.ID.ToLower().StartsWith(textBoxSearchc.Text.ToLower()) || pro.Name.ToLower().StartsWith(textBoxSearchc.Text.ToLower())).
                ToList().
                ForEach(pro => {
                    ListViewItem item = new ListViewItem();
                    item.Text = pro.ID;
                    item.SubItems.Add(pro.Name);
                    item.SubItems.Add(pro.Price.ToString());
                    item.SubItems.Add(pro.Qty.ToString());
                    item.SubItems.Add(pro.Amount.ToString());
                    listView1.Items.Add(item);
                });
            */
            //3 way
              foreach (Product product in source)
              {
                if (product.Name.ToLower().StartsWith(textBoxSearchc.Text.ToLower())||product.ID.ToLower().StartsWith(textBoxSearchc.Text.ToLower()))
                  {
                   
                    ListViewItem item = new ListViewItem();
                    item.Text = product.ID;
                    item.SubItems.Add(product.Name);
                    item.SubItems.Add(product.Price.ToString());
                    item.SubItems.Add(product.Qty.ToString());
                    item.SubItems.Add(product.Amount.ToString());
                    listView1.Items.Add(item);
                  }
            }
        }
        
        float Total()
        {
            //first way
            float total = 0;
            foreach (Product item in source)
            {
                
                total += item.Amount;
                
            }
          //   float total = source.Sum(pro => pro.Amount);
          //   return total;
            //*Search 2se way*//
         //   var product =source.Where( pro=>pro.ID.ToLower().StartsWith(textBoxSearchc.Text.ToLower())||pro.Name.ToLower().StartsWith(textBoxSearchc.Text.ToLower()));
           
            return total;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (listView1.SelectedIndices.Count<=0)
            {
                DisableButton(buttonEDite);
            }
            EnableButton(buttonEDite);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



    }
}
