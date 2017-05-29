using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File
{
    class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public System.Drawing.Image Picture { get; set; }
        public string ImageName { get; set; }

        public string GetInfo()
        {
            string value = ID + "|" + Name + "|" + Gender + "|" + ImageName;//ImageExtention;
            return value;
        }
    
    }
}
