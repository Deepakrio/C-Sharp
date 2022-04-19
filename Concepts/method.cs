using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    public class method
    {
        //Static method
        public static void add(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("{0} + {1} = {2}",a,b,result);
        }

        //Instance method
        public void sub(int a,int b)
        {
            int result = a- b;
            Console.WriteLine("{0} - {1} = {2}", a, b, result);
        }

        public static void Main()
        {
            //Invoking static method
            add(10, 10);

            //Invoking instance method
            method m = new method();
            m.sub(15, 5);
        }
    }
}
