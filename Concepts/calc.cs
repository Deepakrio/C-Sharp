using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    public class calc
    {
        //method for calci App
        public void calci()
        {
            //Declaration of variable
            int opt, a, b, result;
            char c='y';

            //While loop for checking exit an entry for the calci App
            while (c == 'y')
            {
                //Calci options available
                Console.WriteLine("Enter your option");
            Console.WriteLine("1.ADD\t2.SUBTRACTION\t3.MULTIPLICATION\t4.DIVISION");
            opt = Convert.ToInt32(Console.ReadLine());

            //Switch statement
            switch (opt)
            {
                    //Case 1 for Addition
                case 1:
                    Console.WriteLine("*******ADDITION*********");
                    Console.WriteLine("Enter 1st number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number");
                    b= Convert.ToInt32(Console.ReadLine());
                    result = a + b;
                    Console.WriteLine("Addition of {0} + {1} = {2}",a,b,result);
                        Console.WriteLine("Do want to stay in calci for some more time [y/n]");
                        c=Convert.ToChar(Console.ReadLine());

                    break;

                        //Case 2 for subtraction
                case 2:
                    Console.WriteLine("*******SUBTRACTION*********");
                    Console.WriteLine("Enter 1st number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a - b;
                    Console.WriteLine("Subtraction of {0} - {1} = {2}", a, b, result);
                        Console.WriteLine("Do want to stay in calci for some more time [y/n]");
                        c = Convert.ToChar(Console.ReadLine());

                        break;

                        //case 3 for multiplication
                case 3:
                    Console.WriteLine("*******MULTIPLICATION*********");
                    Console.WriteLine("Enter 1st number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a * b;
                    Console.WriteLine("Multiplication of {0} x {1} = {2}", a, b, result);
                        Console.WriteLine("Do want to stay in calci for some more time [y/n]");
                        c = Convert.ToChar(Console.ReadLine());

                        break;

                        //case 4 for division
                case 4:
                    Console.WriteLine("*******Division*********");
                    Console.WriteLine("Enter 1st number");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number");
                    b = Convert.ToInt32(Console.ReadLine());
                    result = a / b;
                    Console.WriteLine("Division of {0} / {1} = {2}", a, b, result);
                        Console.WriteLine("Do want to stay in calci for some more time [y/n]");
                        c = Convert.ToChar(Console.ReadLine());

                        break;

                        //default state
                default: Console.WriteLine("Invalid option");
                        Console.WriteLine("Do you like to try again? [y/n]");
                        c = Convert.ToChar(Console.ReadLine());

                        break;

            }
        }
        }

        //main method
        public static void Main()
        {
            //creating object of type calc
            calc c1 = new calc();

            //invoking calci method
            c1.calci();
        }
    }
}
