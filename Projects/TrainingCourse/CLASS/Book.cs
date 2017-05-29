using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
  public  class Book
    {
        public string ID="";  //if we not set public the defualt is private
        public string Title="";
        public string Author="";
        public DateTime  PublishDate;

        public string GetInfo()
        {
            string info="ID:"+ID+"\nTitle:"+Title+"\nAuthor:"+Author+"\nPublishDate:"+PublishDate.ToString("dd/MMM/yy");
            return info;
        }
    }
}
