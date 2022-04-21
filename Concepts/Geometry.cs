using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2. Show the working of 2 Interfaces(interface1(area()),interface2(perimeter()))

namespace Concepts
{
    public interface Iinterface1
    {
        public void area();
    }

    public interface Iinterface2
    {
        public void perimeter();

    }

    public class triangle : Iinterface1, Iinterface2
    {
        void Iinterface1.area()
        {
            int b = 0, h = 0;
            double result = 0.0;
            Console.WriteLine("**********Area of a Triangle**********\n");
            Console.Write("Enter the base value of a triangle   : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the height of the triangle     : ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            result = 0.5 * b * h;
            Console.WriteLine("\nArea of a Triangle is {0}      : ", result);
        }

        void Iinterface2.perimeter()
        {
            int a = 0, b = 0, c = 0;
            int result = 0;
            Console.WriteLine("**********Perimeter of a Triangle**********\n");
            Console.Write("\nEnter the lenght of 'AB' side of a Triangle  : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the lenght of 'AC' side of a Triangle  : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the lenght of 'BC' side of a Triangle  : ");
            c = Convert.ToInt32(Console.ReadLine());

            result = a + b + c;

            Console.WriteLine("\nPerimeter of a Triangle is {0}           : ", result);


        }
    }

    public class circle : Iinterface1, Iinterface2
    {
        void Iinterface1.area()
        {
            int r = 0;
            double result;
            Console.WriteLine("**********Area of a circle**********\n");
            Console.WriteLine("Enter the radius of a Circle");
            r = Convert.ToInt32(Console.ReadLine());

            result = 3.14 * r * r;

            Console.WriteLine("\nArea of a Circle is {0} ", result);

        }

        void Iinterface2.perimeter()
        {
            int r = 0;
            double result;
            Console.WriteLine("**********Perimeter of a circle**********\n");
            Console.WriteLine("Enter the radius of a Circle");
            r = Convert.ToInt32(Console.ReadLine());

            result = 2 * (3.14 * r);

            Console.WriteLine("\nPerimeter of a Circle is {0} ", result);

        }
    }

    public class rectangle : Iinterface1, Iinterface2
    {
        void Iinterface1.area()
        {
            int l = 0, w = 0;
            int result = 0;

            Console.WriteLine("**********Area of a Rectangle**********\n");
            Console.WriteLine("Enter the length of a Rectangle : ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Width of a Rectangle : ");
            w = Convert.ToInt32(Console.ReadLine());

            result = w * l;

            Console.WriteLine("Area of a Rectangle is : {0}", result);
        }

        void Iinterface2.perimeter()
        {
            int l = 0, w = 0;
            int result = 0;

            Console.WriteLine("**********Perimeter of a Rectangle**********\n");
            Console.WriteLine("Enter the length of a Rectangle : ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Width of a Rectangle : ");
            w = Convert.ToInt32(Console.ReadLine());

            result = 2 * (w + l);

            Console.WriteLine("Perimeter of a Rectangle is : {0}", result);
        }
    }

    public class Square : Iinterface1, Iinterface2
    {
        void Iinterface1.area()
        {
            int a, result;
            Console.WriteLine("**********Area of a Square**********\n");
            Console.WriteLine("Enter the lenght of a square(one side's) : ");
            a = Convert.ToInt32(Console.ReadLine());

            result = a * a;
            Console.WriteLine("\n Area of a Square is : {0}", result);

        }

        void Iinterface2.perimeter()
        {

            int a, result;
            Console.WriteLine("**********Perimwter of a Square**********\n");
            Console.WriteLine("Enter the lenght of a square(one side's) : ");
            a = Convert.ToInt32(Console.ReadLine());

            result = 4 * a;
            System.Console.WriteLine("\n Perimeter of a Square is : {0}", result);


        }
    }
    public class Geometry
    {
        public static void Main()
        {
            int opt;
            char rep = 'y';
            Console.WriteLine("Calculate Area and Perimeters\n");
            

            while (rep == 'y' || rep == 'Y')
            {
                Console.WriteLine("Select Your Option\n");
                Console.WriteLine("1: Triangle\t 2:Circle\t 3:Rectangle\t 4:Square\n");
                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {

                    case 1:
                        Iinterface1 t = new triangle();
                        t.area();
                        Console.WriteLine();
                        Iinterface2 t1 = new triangle();
                        t1.perimeter();
                        Console.WriteLine("Do You wanna Stay in Geometry World? [Y/N] : ");
                        rep = Convert.ToChar(Console.ReadLine());
                        break;

                    case 2:
                        Iinterface1 c = new circle();
                        c.area();
                        Console.WriteLine();
                        Iinterface2 c1 = new circle();
                        c1.perimeter();
                        Console.WriteLine("Do You wanna Stay in Geometry World? [Y/N] : ");
                        rep = Convert.ToChar(Console.ReadLine());
                        break;

                    case 3:
                        Iinterface1 r = new rectangle();
                        r.area();
                        Console.WriteLine();
                        Iinterface2 r1 = new rectangle();
                        r1.perimeter();
                        Console.WriteLine("Do You wanna Stay in Geometry World? [Y/N] : ");
                        rep = Convert.ToChar(Console.ReadLine());
                        break;

                    case 4:
                        Iinterface1 s = new Square();
                        s.area();
                        Console.WriteLine();
                        Iinterface2 s1 = new Square();
                        s1.perimeter();
                        Console.WriteLine("Do You wanna Stay in Geometry World? [Y/N] : ");
                        rep = Convert.ToChar(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        Console.WriteLine("Try Again? [Y/N] : ");
                        rep = Convert.ToChar(Console.ReadLine());
                        break ;
                }
            }




        }
    }
}
    



    

