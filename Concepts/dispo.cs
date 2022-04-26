using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author $Deepak C.R
 * Show the working of Dispose method.
 */

namespace concepts
{
    //Implementing Idisposable interface
    public class dispo : IDisposable
    {
        //Dispose method
        public void Dispose()
        {
            Console.Write("cache memory cleared");
        } 

    }

    public class calc
    {
        //Creating a constructor
        public calc()
        {
            int a = 10, b = 10, c = 0;
            c = a + b;
            Console.WriteLine("addition complete {0} + {1} = {2}", a, b, c);
        }

        //Destructor
        ~calc()
        {
            Console.WriteLine("addition operation disabled");
        }

    }

    public class gc
    {
    public static void Main()
        {
            //Creating reference Variable
            calc c = new calc();
            dispo d = new dispo();
            //Invoking dispose method
            d.Dispose();

            Console.ReadKey();

            

        }

    }


}
