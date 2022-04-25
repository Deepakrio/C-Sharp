using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author $Deepak C.R
 *  Show the working of multiple catch.
 */

namespace Concepts
{
    class multicatch
    {
            //Main method
            public static void Main()
            {
                //Variable declaration
              
                int a, b, div;
                Console.WriteLine("Enter 2 Numbers");
       

            //Try block
            try
                {
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    div = a / b;
                    Console.WriteLine("{0} / {1} = {2}",a,b,div);
                }
                //Catch block1
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }

                //Catch block2
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }

