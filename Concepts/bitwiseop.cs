using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    public class bitwiseop
    {
        //Main method
        public static void Main()
        {
        //Variable Declaration part
        int a = 20;
        int b = 30;
        int c;

        //bitwise AND operator
        c = a & b;
            Console.WriteLine("The bitwise and of {0} & {1} = {2}\n", a, b, c);
        
        //bitwise OR operator
        c = a | b;
            Console.WriteLine("The bitwise or of {0} | {1} = {2}\n", a, b, c);

        //bitwise XOR operator
        c = a ^ b;
            Console.WriteLine("The bitwise xor of {0} ^ {1} = {2}\n", a, b, c);

        //Bitwise Complement
         Console.WriteLine($"Bitwise Complement of {a} is\n " + (~a));

        //Right shift Operator
         Console.WriteLine("Demonstration of Right Shift operator\n" + (b >> 2));
        
        //Left Shift Operator
        Console.WriteLine("Demonstration of Left Shift operator\n" + (b << 3));


        }


    }
}
