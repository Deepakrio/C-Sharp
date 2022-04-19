using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    //declaring public class floyd
    public class floyd
    {
        public static void Main()
        {
            //Declaring integer variable m and n for (for loop)
            int m, n,p;
            //Getting user input for the size of floyd triangle
            Console.WriteLine("Enter the size of floyd triangle");
            p = Convert.ToInt32(Console.ReadLine());
            //Outer for loop
            for (m = 1; m <= p; m++)
            {
                //Inner for loop
                for (n = 1; n < m + 1; n++)
                {
                    //using * special character for floyd triangle
                    Console.Write( " * ");
                }
                //to get into next line
                Console.WriteLine();
            }
        }
    }
}
