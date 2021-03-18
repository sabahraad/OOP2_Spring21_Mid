using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Student S1 = new Student("Sabah Raad","18-38242-2",3.61f);
                Student S2 = new Student("Saad", "18-38243-2", 3.80f);
                Student S3 = new Student("Rudmila", "18-38244-2", 2.8f);
                Department D1 = new Department("Computer Science Engineering", "01");
                Department D2 = new Department("Bachelor of Business Administration", "02");
                
                D1.AddStudent(S1);
                D1.AllStudent();
                D2.AddStudent(S2,S3);
                D2.AllStudent();

            }
    }
}
