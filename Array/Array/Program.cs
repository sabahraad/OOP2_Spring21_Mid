using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] arr2 = new int[10];
            

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 100;
            }
            for (int i = 0; i< 10; i++)
            {
                arr2[i] = arr[i];
            }

           
            Console.Write("the first array :");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }

           
            Console.Write("the second array :");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }
            Console.Write("\n\n");
        }
    }
}

