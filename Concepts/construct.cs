using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    public class construct
    {
        //Default Constructoe
        public construct()
        {
            Console.WriteLine("Welcome to Math World");

        }
        //constructor with parameter which calculates Sqr for a given number
        public construct(int a)
        {
            int b = a * a;
            Console.WriteLine("Square root of {0} is {1} ", a, b);
        }
        //constructor with parameter which calculates cube for a given number
        public construct(float a)
        {
           float b = a * a * a;
            Console.WriteLine("{0} cube is {1}",a,b);
        }
        //constructor with parameter which Adds the given integers 
        public construct(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Addition of {0} and {1} is {2}", a, b, c);
        }
        //constructor with parameter which Subtracts a given integer ang long int 
        public construct(double a, int b)
        {
            double c = a - b;
            Console.WriteLine("Subtraction of {0} and {1} is {2}", a, b, c);
        }
        //constructor with parameter which Multiplies a given integer ang long int 
        public construct(int a, double b)
        {
         double c = a * b;
            Console.WriteLine("Multiplication  of {0} and {1} is {2}", a, b, c);
        }

        public static void Main()
        {
            //default constructor
            construct c = new construct();

            //parameter constructor1
            construct c1 = new construct(3);

            //overloading parameter constructor1
            construct c2 = new construct(4.0f);

            //constructor with 2 parameters
            construct c3 = new construct(5,9);

            //overloading constructor with 2 parameters by using different data type
            construct c4 = new construct(7.0,9);

            //overloading constructor with 2 parameters by changing the sequence of data types
            construct c5 = new construct(8,9.0);

        }
    }
}
