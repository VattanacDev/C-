using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
  public  class Product
    {
      /*
      public string ID = "";
      public string Name = "";
      public float QTY=0f;
      public float Price = 0f;
      */
        public string ID { get; set; }
        public string Name { get; set; }
        public float Qty { get; set; }
        public float Price { get; set; }
        public float Amount 
        { 
            get { return Qty * Price; } 
        }

      public string GetInfo()
        {
            string info = "ID:" + ID + "\nName:" + Name + "\nQty:" + Qty + "\nPrice:" + Price + "\nAmount:" + Amount;
            return info;
        }
    }
}
