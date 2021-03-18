using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Department
    {
        private string deptName;

        public string Deptname
        {
            get { return deptName; }
            set { deptName = value; }
        }
        private string deptid;

        public string DeptId
        {
            get { return deptid; }
            set { deptid = value; }
        }


        public Student[] students;

        public int studentCount = 0;

        public Department()
        {
            students = new Student[10];
        }

        public Department(string deptName, string deptid) : this()
        {

            this.deptName = deptName;
            this.deptid = deptid;


        }

        public void AddStudent(params Student[] students)
        {
            foreach (Student s in students)
            {

                this.students[studentCount++] = s;
                s.Dept = this;

            }
        }

        public void AllStudent()
        {
            for (int i = 0; i < studentCount; i++)
            {
                students[i].ShowInfo();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Department Name:" + deptName);
            Console.WriteLine("Department Id:" + deptid);

        }
    }
}
