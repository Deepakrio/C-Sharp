using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Show the working of NULL COALESCING OPERATOR ??

namespace Concepts
{
    public class coalescing
    {
        //Main method
        public static void Main()
        {
        //Declaring Nullables
        string? Fname = null;
        string? Lname = null;
        
        //Declaring normal string and assigning values
        string firstname = "Deepak";
        string lastname = "Rio";

            //using Coalescing for the variable Fname and Lname to fill the Null values
            Fname = firstname ?? lastname;
            Lname = lastname ?? firstname;

            //Printing the output string
            Console.WriteLine($"{firstname} {lastname}");

        }

    }
}
