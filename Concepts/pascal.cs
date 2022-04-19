using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    //Declaring public class pascal
    public class pascal
    {
        //Main method
        public static void Main()
        {
            ///<summary>
            ///Variable Declaration 
            ///var n is for getting size of an pascal triangle
            ///var tri is to calculate the values and var space is to print space
            ///</summary>
            int n , tri = 1, space, i, j;
            Console.WriteLine("Pascal's triangle");

            //Getting size for the pascal triangle from the user Example 5
            Console.WriteLine("Enter the size of Pascal triangle");
                n=Convert.ToInt32(Console.ReadLine());

            //outer for loop handles the rows
            for (i = 0; i < n; i++)
            {
                //This inner for loop is use to print the empty spaces so that we get a pyramid shaped triangle
                for (space = 1; space <= n - i; space++)
                    Console.Write(" ");
                //This inner for loop injects the value inside the rows
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        tri = 1;
                    else
                        //Pattern generation logic
                        tri = tri * (i - j + 1) / j;                                     
                    Console.Write(tri + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
