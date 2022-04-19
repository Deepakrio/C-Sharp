using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    //  Write a program to perform matrix addition using 2D Arrays.
    public class Addmatrix
    {
        //Main method
        public static void Main()
        {
            //Declaring three 2D array for holding matrix values
            int[,] matrix1 = new int[20, 20];
            int[,] matrix2 = new int[20, 20];
            int[,] sum = new int[20, 20];

            //variable i and j are used in for loop and variable n holds the number of rows
            int i, j, n;

            //Getting the number of rows info from the user
            Console.WriteLine("Enter the row size for the matrix");
            n=Convert.ToInt32(Console.ReadLine());

            //Getting the values for matrix 1 from the user
            Console.WriteLine("Enter the values for Matrix1");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Getting the values for matrix 2 from the user
            Console.WriteLine("Enter the Values for Matrix2");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            //Displaying the values inside matrix 1
            Console.WriteLine("\nMatrix1 value is:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (j = 0; j < n; j++)
                    Console.Write(matrix1[i, j] + "\t");    
            }

            //Displaying the values inside matrix 2
            Console.WriteLine("\n\nMatrix2 value is:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (j = 0; j < n; j++)
                    Console.Write(matrix2[i, j] + "\t");
            }

            //Logic for Addition of Two matrix
            for (i = 0; i < n; i++)
                   for (j = 0; j < n; j++)
                    sum[i, j] = matrix1[i, j] + matrix2[i, j];
                

            //Displaying the result of Addition of two matrix
            Console.WriteLine("\n\nAddition of Two Matrix are");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (j = 0; j < n; j++)
                    Console.Write(sum[i, j] + "\t");
            }

        }


    }
}
