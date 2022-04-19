using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21
{
    //Creating class Avg
    public class Avg
    {
        //Declaration and intialization of variables
        int sub1=0,sub2=0,sub3=0,total=0,avg=0;

        //method to calculate total sum of 3 subject and average of 3 subject
        public  void totalavg()
        {
            int opt,temp=0;
            Console.WriteLine("Enter the marks for Subject 1");
            sub1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks for Subject 2");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks for Subject 3");
            sub3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1 To Calculate the Total or Enter 2 To Calculate the Avg");
            opt = Convert.ToInt32(Console.ReadLine());

            if(opt == 1)
            {
                total = sub1 + sub2 + sub3;
                Console.WriteLine("Total = {0}", total);
            }
            else
            {
                temp = sub1 + sub2 + sub3;
                avg = temp / 3;
                Console.WriteLine("Avg = {0}", avg);
            }

        }

        //main method
        public static void Main()
        {
           //creating object of type Avg
           Avg avg = new Avg();

            //invoking totalavg instance method
           avg. totalavg();


        }

    }
}
