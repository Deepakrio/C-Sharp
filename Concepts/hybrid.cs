using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//3. Show the working of Hybrid Inheritance

namespace Concepts
{
   /// <summary>
   /// This program has multilevel inheritance and hirarchical inheritance
   /// This combination will form hybrid inheritance
   /// </summary>


    //Base Class
    public class math
    {
        //variable Declaration
        int a, b, res;
        double result;

        //Defining addition function
        public void add(int a,int b)
        {
            res = a + b;
            Console.WriteLine("Addition of {0} + {1} = {2}",a,b,res);
        }

        //Defining subtraction function
        public void sub(int a,int b)
        {
            res= a - b;
            Console.WriteLine("Subtraction of {0} - {1} = {2}", a, b, res);
        }

        //Defining multiplication function
        public void mux(int a,int b)
        {
            res = a * b;
            Console.WriteLine("Multiplication of {0} x {1} = {2}", a, b, res);
        }

        //Defining division function
        public void div(int a,int b)
        {
            result = a / b; 
            Console.WriteLine("Division of {0} / {1} = {2}",a,b,result);
        }

    }
    //Intermediate class1
    public class addition : math
    {
        
        public void display1()
        {
            Console.WriteLine("*************ADDITION*************");
        }
    }

    //Intermediate class2
    public class Subtraction : addition
    {
        public void display2()
        {
            Console.WriteLine("*************SUBTRACTION*************");
        }
    }


    //Derived class from Subtraction [Hirarchical inheritance]
    public class Multiplication : Subtraction
    {
        public void display3()
        {
            Console.WriteLine("*************MULTIPLICATION*************");
        }
    }

    //Derived class from Subtraction [Hirarchical inheritance]
    public class Division : Subtraction
    {
        public void display4()
        {
            Console.WriteLine("*************DIVISION*************");
        }
    }

    public class hybrid
    {
        //Main method
        public static void Main()
        {
            //creating instance for addition class
            addition a = new addition();
            a.display1();
            a.add(10,10);
            Console.WriteLine();

            //creating instance for substraction
            Subtraction s = new Subtraction();
            s.display2();
            s.sub(10,10);
            Console.WriteLine();

            //creating instance for multiplication
            Multiplication m = new Multiplication();
            m.display3();
            m.mux(10,10);
            Console.WriteLine();

            //creating instance for division
            Division d = new Division();
            d.display4();
            d.div(10,10);
            Console.WriteLine();

        }
    }
}
