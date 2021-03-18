using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Pass_by_value
{
    class Program
    {
        static void swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y= temp;
        }
        static void string_swap(string a,string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        static void outexample(out int a)
        {
            a = 5050;
        }
        static void Main(string[] args)
        {
            int x = 10, y = 12;
            Console.WriteLine("x ={0}     and    y={1} ", x, y);
            swap(ref x, ref y);
            Console.WriteLine("x ={0}     and    y={1} ", x, y);


            int a;
            outexample(out a);
            Console.WriteLine(a);


            Student S1 = new Student();
            S1.Name = "raad";
            Student S2 = new Student();
            S2.Name = "Saad";
            S2.Id = 20;
            Console.WriteLine("Student id: " + S2.Id);

            Console.WriteLine("Student Name: " + S1.Name);
            Console.WriteLine("Student Name: " + S2.Name); 
            Console.WriteLine("Created Student: " + Student.count); 

        }
    }
}
