using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    //Creating a Generic Class
    public class Gencalc<T>
    {
        //Creating generic method Addition
        public T Addition(T a, T b)
        {
            ///<summary>
            ///We cannot use operators like +,-,*,/ on a generic type (T)
            ///so we have created dynamic type variables and assigned generic values in it
            ///and we have performed operations on dynamic type variable
            ///</summary>
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 + num2;
        }

        //Generic method Subtraction
        public T Subtraction(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 - num2;
        }

        //Generic method multiplication
        public T Multiplication(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 * num2;
        }

        //Generic method Division
        public T Division(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 / num2;
        }

        //Generic method percentage
        public T Percentage(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return (num1 / num2) * 100;
        }


    }


    public class calci
    {
        //Main method
        public static void Main()
        {
            //Variable declaration
            int opt;
            char c = 'y';
            int a=0, b=0;
            double d = 0,e= 0;

            //Creating instance for generic class 
            Gencalc<int> cal = new Gencalc<int>();
            Gencalc<double> cal2 = new Gencalc<double>();
            Console.WriteLine("Generic Calculator App");
         

            while (c == 'y' || c == 'Y')
           
            {
                Console.WriteLine("\n1:ADDITION\t 2:SUBTRACTION\t 3:MULTIPLICATION\t 4:DIVISION\t 5:PERCENTAGE\n");
                opt = Convert.ToInt32(Console.ReadLine());

                //Switch case
                switch (opt)

                {
                    //Case 1 performs Addition operation of int type
                    case 1:
                        Console.Write("Enter 1st number   : ");
                        a=Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter 2nd number : ");
                        b=Convert.ToInt32(Console.ReadLine());
                        int sum = cal.Addition(a, b);
                        Console.WriteLine("Addition :{0}", sum);
                        Console.Write("Do you wanna stay in Generic Calculator APP? [Y/N] : ");
                        c = Convert.ToChar(Console.ReadLine());
                        break;

                    //Case 2 performs Subtraction operation of int type
                    case 2:
                        Console.Write("Enter 1st number   : ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter 2nd number : ");
                        b = Convert.ToInt32(Console.ReadLine());
                        int val = cal.Subtraction(a, b);
                        Console.WriteLine("\nSubtraction :{0}", val);
                        Console.Write("Do you wanna stay in Generic Calculator APP? [Y/N] : ");
                        c = Convert.ToChar(Console.ReadLine());
                        break;

                    //Case 3 performs Multiplication operation on int type
                    case 3:
                        Console.Write("Enter 1st number   : ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter 2nd number : ");
                        b = Convert.ToInt32(Console.ReadLine());
                        int mux = cal.Multiplication(a, b);
                        Console.WriteLine("\nMultiplication :{0}", mux);
                        Console.Write("Do you wanna stay in Generic Calculator APP? [Y/N] : ");
                        c = Convert.ToChar(Console.ReadLine());
                        break;
                    
                    //Case 4 performs Division operation
                    case 4:
                        Console.Write("Enter 1st number   : ");
                        d = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nEnter 2nd number : ");
                        e = Convert.ToDouble(Console.ReadLine());
                        double div = cal2.Division(d, e);
                        Console.WriteLine("\nDivision :{0}", div);
                        Console.Write("Do you wanna stay in Generic Calculator APP? [Y/N] : ");
                        c = Convert.ToChar(Console.ReadLine());
                        break;
                    
                    //Case 5 performs percentage operation
                    case 5:

                        Console.Write("Enter Obtained Marks   : ");
                        d = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nEnter Total Marks : ");
                        e = Convert.ToDouble(Console.ReadLine());
                        double per = cal2.Percentage(d, e);
                        Console.WriteLine("\nPercentage :{0}", per);
                        Console.Write("Do you wanna stay in Generic Calculator APP? [Y/N] : ");
                        c = Convert.ToChar(Console.ReadLine());
                        break;

                    //Default state
                    default:
                        Console.WriteLine("Invalid option");
                        Console.Write("Try Again? [Y/N] : ");
                        c = Convert.ToChar(Console.ReadLine());
                        break;


                }

            }
        }
    }
}
