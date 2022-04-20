using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging
{
    public class SwapExample
    {
        public static void Main()
        {
            int a=10, b=20;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            Console.Write("After swap a= " + b + " b= " + a);

            a = a * b;
            a = a / b;
            a = a / b;
        }
    }

}
