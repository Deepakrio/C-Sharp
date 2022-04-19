using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    public class Ternary_brk_cnt
    {
        //Ternary operator example
        public static void ternary()
        {
            int a = 20, b = 10;
            Console.WriteLine("This is an example of ternary operator");


            var result = a > b ? "a is greater than b" : "b Greater then a";

            Console.WriteLine(result);
        }

        //break Example
        public static void stop()
        {
            int n = 20;
            Console.WriteLine("\n this is an example of break;");

            //prints only 10 value because break is applied when the i = 10
            for (int i=0;i<n;i++)
            {
                if(i==10)
                {
                    break;
                }
                Console.Write(i+" ");

            }
        }

        //skips the number 10 and continues with remaing numbers
        public static void skip()
        {
            int n = 20;
            Console.WriteLine("\n this is an example of continue;");
            //prints only 10 value because break is applied when the i = 10
            for (int i = 0; i < n; i++)
            {
                if (i == 10)
                {
                    continue;
                }
                Console.Write(i+" ");

            }
        }

        //main method
        public static void Main()
        {
            //invoking static ternary method
            ternary();

            //invoking static stop method
            stop();

            //invoking static skip method
            skip();

        }
    }
}
