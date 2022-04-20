using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    public class Employee
    {

        int n;
        int[] empid;
        string[] empname ;

        public void getdetails()
        {
            
            Console.WriteLine("Enter the number of Employee");
           n=Convert.ToInt32(Console.ReadLine());

            empid=new int[n];
            empname=new string[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Employee ID");
                empid[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee Name");
                empname[i] = Console.ReadLine();
            }
        }

        public void display()
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Employee Name : {0}",empname[i]);
                Console.WriteLine("Employee ID   : {0}",empid[i]);
                Console.WriteLine("\n");

            }

        }

        public static void Main()
        {
           
            Employee emp = new Employee();
            emp.getdetails();
            Console.WriteLine();
            emp.display();
        }
    }
}
