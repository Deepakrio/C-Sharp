using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    internal class sum
    {
        //method to calculate sum of given natural numbers
        public void natural()
        {
            //Declaration and intialization of variables
            int n = 0, sum = 0, count=0;

            //getting the number range
            Console.Write("Enter the Range for natural numbers: 1 to ");
            n = Convert.ToInt32(Console.ReadLine());

            //incrementing the range number by 1 for the programming logic
            n = n + 1;

            //while loop
            while(count != n )
            {
                //adds the count value to the updated sum value in every itteration until condition gets false
                sum += count;

                //incrementing count by one 
                count++;

            }
            //Display's sum of natural numbers
            Console.WriteLine("the Sum of natural numbers is : {0}", sum);
        }

        //main method
        public static void Main()
        {
            //creating object of type sum
            sum s = new sum();
            //invoking natural method
            s.natural();
        }
    }
}
