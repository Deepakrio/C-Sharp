using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program to perform sum of natural numbers using params array.

namespace Concepts
{
public class paramarray
    {
        public static void paramsarray (params int[] arr)
        {
            int sum = 0;

            for (int i=0; i<arr.Length; i++)
            {
                sum += arr[i];
                
            }
            Console.WriteLine("Sum of natural numbers is {0}",sum);

        }

        public static void Main()
        {
            int n;

            Console.WriteLine("Enter the size of the array");
            n = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[n];

            Console.WriteLine("Enter the Values");
            for(int i=0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            paramsarray(num);
            Console.Write("\n\n");


        }
    }
}
