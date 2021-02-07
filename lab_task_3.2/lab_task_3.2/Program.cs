using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_task_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = 100;
                int e_sum = 0;
                int odd_sum = 0;


                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    e_sum = e_sum + i; 
                    else
                    odd_sum = odd_sum + i;

                }
                Console.WriteLine(e_sum);
                Console.WriteLine(odd_sum);

                Console.ReadKey();
            }
        }
    }

}

