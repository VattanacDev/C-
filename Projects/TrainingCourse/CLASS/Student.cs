using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    class Student:People
    {
        public string subject { get; set; }
        public string grade { get; set; }
        public string getFullName ()
        {
            return base.FirstName + base.LastName;
        }
        public override string getInfo()
        {
            return base.getInfo() + "\nSubject:" + subject + "\nGrade:" + grade + "\nFullName:" + getFullName();
            
        }
    }
}
