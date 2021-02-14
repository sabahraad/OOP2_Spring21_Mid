using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 3, 6, 4, 2, 7, 6, 2, 3 };

            Console.WriteLine("Duplicate elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[j]);
                    }
                }
            }

        }
    }
}
