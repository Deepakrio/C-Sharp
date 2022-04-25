using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author $Deepak C.R
 * Show the working of Multi-cast delegate.
 */

namespace Concepts
{
    //Delegate method
    public delegate void Movie(string a, string b);
    internal class Delegates
    {
    //Movie ticket method(BENGALURU)
      public void ticket(string a,string b)
        {
            Console.WriteLine("******MOVIE BOOKING BENGALURU******\n");
            Console.WriteLine("{0} Ticket is confirmed for {1} movie", a, b);
            Console.WriteLine("Language: Kannada\t 2D Picture\t Price : 300/-\n");
        }

        //Movie ticket method(COIMBATORE)
        public void ticket2(string a,string b)
        {
            Console.WriteLine("******MOVIE BOOKING COIMBATORE******\n");
            Console.WriteLine("{0} Ticket is confirmed for {1} movie", a, b);
            Console.WriteLine("Language: Tamil\t 2D Picture\t Price : 500/-\n");

        }

        //Main method
        public static void Main()
        {
            //Creating instance for delegates class
        Delegates del = new Delegates();

            //Multi cast Delegate
            Movie mov = del.ticket;
            mov += del.ticket2;

            mov("2", "KGF");
            Console.WriteLine();

        }
    }
}
