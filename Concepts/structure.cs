using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to show the working of parameterized constructors using Structures.

namespace Concepts
{
    //Creating a structure of name cal which holds the parameterized constructor 
    struct cal
    {
        //Parametrerized Constructor for displaying the message
        public cal (String msg)
        {
            Console.WriteLine (msg);
        }
        //Parameterized Constructor for calci application
        public cal(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("\t\t{0} + {1} = {2} ",a,b,c);
            c = a - b;
            Console.WriteLine("\t\t{0} - {1} = {2} ", a, b, c);
            c = a * b;
            Console.WriteLine("\t\t{0} x {1} = {2} ", a, b, c);
            c = b / a;
            Console.WriteLine("\t\t{0} / {1} = {2} ", b, a, c);
        }
    }
    public class structure
    {
        public static void Main()
        {
        cal c1 = new cal("***********Welcome to Calci Application***********\n");
        cal c = new cal(10,100);

        }

    }
}
