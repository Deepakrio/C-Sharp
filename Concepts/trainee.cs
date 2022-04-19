using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    //creating a class trainee
    public class trainee
    {
        int Tid;
        long phno;
        string Tname;
        string mail;

        //method for reading data
        public void getinfo()
        {
            Console.WriteLine("Enter Trainee ID");
            Tid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Trainee Name");
            Tname = Console.ReadLine();   
            Console.WriteLine("Enter Trainee phone number");
            phno = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Traine E-mail ID");
            mail = Console.ReadLine();
        }

        //method for displaying the data
        public void display()
        {
            Console.WriteLine("Trainee ID    : {0}",Tid);
            Console.WriteLine($"Trainee Name : {Tname}");
            Console.WriteLine("Phone Number  : {0}", phno);
            Console.WriteLine($"E-mail       : {mail}");
        }

        //main method
        public static void Main()
        {
            int n;
            //creating object of trainee type
            trainee t = new trainee();
            //Asking for how many number of records to be entered
            Console.WriteLine("Enter the number of Trainees");
            n=Convert.ToInt32(Console.ReadLine());

            //for loop 
            for (int i = 0; i < n; i++)
            {
                //invoking getinfo method
                t.getinfo();
                Console.WriteLine("");
                //invoking display method
                t.display();
                Console.WriteLine("");
                Console.WriteLine("Trainee Details Added Successfully");


            }
        }
    }
}