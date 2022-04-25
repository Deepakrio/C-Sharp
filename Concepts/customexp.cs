using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author $Deepak C.R
 *  Create a custom exception for voting eligibility.
 */

namespace Concepts
{
    //custom exception class extending Exception class
    public class minor : Exception
    {
        //Constructor of custom exception class
       public minor()
        {
            Console.WriteLine("Sorry you cannot vote! you are still a MINOR");
        }

       
    }

    //Main class
    public class Voting
    {
        //Variable declaration
        string name;
        int age;

        //Vote method
        public void vote(int age)
        {
            if(age < 18)
            {
                throw new minor();
            }
          
            else
            {
                Console.WriteLine($"\n{name} can Vote This Year");
            }
        }

        //Main method
        public static void Main()
        {
            //Creating reference variable
            Voting v = new Voting();
            Console.WriteLine("******************VOTING PORTAL********************");
            Console.WriteLine("Enter your Name");
           v.name=Console.ReadLine();
            Console.WriteLine("\nEnter your Age");
            v.age = Convert.ToInt32(Console.ReadLine());

            //Try block
            try
            {
                v.vote(v.age);
            }

            //catch block
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
