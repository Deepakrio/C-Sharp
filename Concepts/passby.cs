using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author $Deepak C.R
 * Explore the difference between pass by value, pass by reference(ref keyword) and pass by out(out keyword) in C#.
 */

namespace Concepts
{
    public class passby
    {
        //pass by value method
        public void sqr(int s)
        {
             s = s * s;
            //value updated for pass by value
            Console.WriteLine("value of pass by value {0}",s);
        }

        //pass by reference using ref keyword 
        public void cube(ref int c)
        {
            c = c * c * c;
            //value updated for pass by reference
            Console.WriteLine("value of pass by Reference {0}",c);
        }

        //pass by out using out keyword
        public void mux(out int m)
        {
            m = 4;
            m = m * 5;
            //value update for pass by out
            Console.WriteLine("value of pass by out {0} ", m);
        }
    }

    public class passbydemo
    {
        public static void Main()
        {

            //variable declaration
            int s = 5, c = 3, m;

            //creating instance variable
            passby pa = new passby();

            //invoking sqr method pass by value
            pa.sqr(s);
            //value after pass by value (not affected original value)
            Console.WriteLine("Value after pass by value {0}\n", s);

            //invoking cube method pass by reference
            pa.cube(ref c);
            //value after pass by reference (Updated reference variable)
            Console.WriteLine("Value after pass by Reference {0}\n", c);

            //invoking mux method pass by out
            pa.mux(out m);
            //value after pass by out (returns calculated value and assigned to passed out variable)
            Console.WriteLine("Value after pass by out {0}", m);



        }

    }
}
