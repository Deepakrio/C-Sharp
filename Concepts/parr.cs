using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task Assigned During Class Hours (params Array) 
namespace task22
{
public class parr
    {
        public static void paramarray (params int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i +" ");
            }
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
            paramarray(num);
            Console.Write("\n\n");


        }
    }
}
