using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public float Qty { get; set; }
        public float Price { get; set; }
       
        public float Amount { get { return Qty * Price; } }
        public System.Drawing.Image Picture { get; set; }
        public string ImageName { get; set; }

        public string GetInfo()
        {
            string value = ID + "|" + Name + "|" 
                + Type + "|" + Qty + "|" + Price + "|" + ImageName;
            return value;
        }
    
    }
}
