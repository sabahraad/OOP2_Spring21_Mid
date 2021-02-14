using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4,5,6,2,2,7,4};

            Console.WriteLine("Unique elements: ");

            for (int i = 0; i < arr.Length;i++)
            {
                int count = 0;
                for (int  j=0; j < arr.Length; j++)
                {
                    
                    if (arr[j] == arr[i])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(arr[i]);
                }
            }


        }
    }
}
