using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    public class str
    {
        public static void Main()
        {

            String str1 = "Dlithe ";
            String str3 = "Bootcamp ";
            
            //String clone method 
            String str2 = (String)str1.Clone();
            
            //String Color Properties
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"This is to demonstrate string clone method:\t{str2}\n");
            Console.ForegroundColor = ConsoleColor.White;

            //String concatination( merging of two or more string
            Console.WriteLine("This is to demonstrate string Concatination method");
            Console.WriteLine((String.Concat(str1,str3))+"\n");

            //String contains method - which checks for the occurance of sub stiong in another string or not 
            //It will return true or false value
            //And Demonstrated Escape Sequence Concepts too
            Console.WriteLine("This is /\\to demonstrate string contains method");
            //Returns false because the strings doesnot match with each other
            Console.WriteLine(str1.Contains(str3));
            //Returns true because the strings will match each other
            Console.WriteLine(str1.Contains(str2)+"\n");

            //Copy string method which copies on string data into another variable
            String str4 = String.Copy(str3);
            Console.WriteLine("This is to demonstrate String Copy method");
            Console.WriteLine(str4 + "\n");

            //Equals String method used to validate between two strings returns bool value
            Console.WriteLine("This is to demonstrate String Equals method");
            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.Equals(str3) + "\n");

            //String Indexof method - used to get the index value for a given character in a string
            Console.WriteLine($"Display's the index of (i) in string {str1}");
            Console.WriteLine(str1.IndexOf('i'));

            //insert method in strings is used to insert a perticular string at perticular index value
            Console.WriteLine("Insert method in strings");
            String str5 = str3.Insert(9, "2022 Batch");
            Console.WriteLine(str5 + "\n");

            //Replace method in strings is used to replace a complete string or just a part of string
            Console.WriteLine("Replace method in strings");
            String str6 = str1.Replace("Dlithe", "Datalyzer");
            Console.WriteLine(str6 + "\n");

            //Substring method is used to get the part of existing string by specifying the start index 
            Console.WriteLine("Substring method in strings concept");
            Console.WriteLine(str3.Substring(4)+"\n");

            //Trim method on String will remove all the whitespaces containing in the begin and end
            String str7 = "    Dlithe Bootcamp     ";
            Console.WriteLine(" Trim method in String concept");
            Console.WriteLine(str7.Trim() + "\n");

           


        }

    }
}
