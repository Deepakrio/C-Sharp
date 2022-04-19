using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    
    public class Jarray
    {
        //Main Method
        public static void Main()
        {
            //Declaring jagged Array of size 2 and single dimension array
            int[][] add = new int[2][]
            {
                new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 },
                new int[] { 5, 4, 3, 2, 1 }

            };

            //Declaring temp variable for storing the sum of the array
            int temp=0;
            Console.WriteLine("Array elements");
            for(int i = 0; i < add.Length; i++)
            {
                for(int j = 0; j < add[i].Length; j++)
                {
                    Console.Write(add[i][j] + " ");
                    //Adds each value to the exisiting temp value      
                   temp += add[i][j];
                }
                //Displays the sum of the array
                Console.WriteLine("Sum of the given array {0}",temp);
                //Re-Initializing the temp value to 0 to store fresh values
                temp = 0;
                 
            }



        }
    }
}
