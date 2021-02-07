using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n=10;
            
            for (int i = 0; i <= n; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            }
        }
    }
