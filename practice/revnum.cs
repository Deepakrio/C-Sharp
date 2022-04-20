using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class revnum
    {
        public static void Main()
        {
            int n,m=0;
            Console.WriteLine("Enter the size for an array");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("\nEnter the numbers");
            for(int i =0;i<arr.Length;i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n\nThe Reverse order for a given number");
            for (int j = 0; j < arr.Length; j++)
            {
                --n;
                Console.WriteLine(arr[n]);
               
            }
            
        }
    }
}

