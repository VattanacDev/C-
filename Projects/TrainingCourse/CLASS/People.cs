using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateBirth { get; set; }

        public virtual string getInfo()
        {
            string result = "ID:" + Id + "\nName:" + FirstName +"\t"+ LastName + "\nGender:" + Gender+"\nBirht:  "+DateBirth.ToString("dd/MMM/yy");
            return result;
        }
    }
}
