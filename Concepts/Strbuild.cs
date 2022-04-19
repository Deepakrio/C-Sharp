using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
   public class Strbuild
    {
        public static void Main()
        {
            //Creating a reference variable for String builder class
            StringBuilder str1 = new StringBuilder("Dlithe ");

            //Using Append String builder method to Append the exeisting String i.e,"Dlithe" and
            //Appending with Bootcamp
            str1.Append("Bootcamp ");

            //Printing the Appended string result now the string holds "Dlithe Bootcamp
            Console.WriteLine("StringBuilder Append Method");
            Console.WriteLine(str1+"\n");


            StringBuilder str3 = new StringBuilder();
            //Using insert method on str1, where it allows us to insert any given string in a specified index
            str3 = str1.Insert(16, "For C-sharp");

            StringBuilder str2 = new StringBuilder();

            ///<summary>
            ///Using AppendFormat to Format the given String as needed 
            ///Here we are adding a brackets around the str2
            ///</summary>
            str2.AppendFormat("({0})",str1);

            //Printing the results
            Console.WriteLine("StringBuilder AppendFormat Method");
            Console.WriteLine(str2+"\n");

            //Printing the result
            Console.WriteLine("StringBuilder Insert Method");
            Console.WriteLine(str3+"\n");

            StringBuilder str4 = new StringBuilder();

            //Using Remove method on str3 to remove a perticular String by giving the index value and the length value
            str4 = str3.Remove(16, 11);

            //Printing the result
            Console.WriteLine("StringBuilder Remove Method");
            Console.WriteLine(str4+"\n");

            StringBuilder str5 = new StringBuilder();
            //Using the replace method to replace a string Dlithe to Datalyzer
            str5 = str1.Replace("Dlithe", "Datalyzer");

            //Printing the Result
            Console.WriteLine("StringBuilder Replace Method");
            Console.WriteLine(str5+"\n");
        }
    }
}
