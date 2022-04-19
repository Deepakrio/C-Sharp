using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    /// <summary>
    /// . Write a program to calculate the sum of naturals numbers using 1D Array
    /// (get the size of the array and input from the user).
    /// </summary>
    
    public class Array1D
    {
        public static void Main()
        {
            int[] array;
            int size=0,sum=0;

            Console.WriteLine("Enter the size of an Array");
            size=Convert.ToInt32(Console.ReadLine());
            array=new int[size];

            Console.WriteLine("Enter the Numbers");
            for(int i=0;i<size;i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
                sum +=array[i];

            }

            Console.WriteLine("The sum of Given Numbers is : {0}",sum);
           
        }

    }
}
