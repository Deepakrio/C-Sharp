using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Show the working of Nullables with various datatype.
//Show the working of NULL COALESCING OPERATOR ??
namespace Concepts
{
    public class Nullables
    {
        //Main method
        public static void Main()
        {

        //Declaring Nullables on various Datatypes
        int? id = null;
        Nullable<float> balance = null;
        double? intrest = null;
        char? gender = null;
        string? name = null;

            //Printing the Null Values
            Console.WriteLine("Nullables\n");
            Console.WriteLine("User ID        : {0}", id);
            Console.WriteLine("Username       : {0}", name);
            Console.WriteLine("Gender         : {0}",gender);
            Console.WriteLine("Balance Amt    : {0}",balance);
            Console.WriteLine("Intrest gained : {0}",intrest);
            
            //Declaring and initializing variables for Coalescing usage
            int ID = 1;
            float BALANCE = 100000.50f;
            double INTREST = 3400.00;
            char GENDER = 'M';
            string NAME = "Deepak";

            //Coalescing the null values
            id = id ?? ID;
            name = name ?? NAME;
            gender = gender ?? GENDER;
            balance = balance ?? BALANCE;
            intrest = intrest ?? INTREST;

            //Printing the updated value
            Console.WriteLine("\n\nCoalescing the Null values\n");

            Console.WriteLine("User ID        : {0}", id);
            Console.WriteLine("Username       : {0}", name);
            Console.WriteLine("Gender         : {0}", gender);
            Console.WriteLine("Balance Amt    : {0}", balance);
            Console.WriteLine("Intrest gained : {0}", intrest);



        }
    }
}
