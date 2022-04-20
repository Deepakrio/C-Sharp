using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Calculate Electricity Bill using Abstraction

namespace Concepts
{

 public abstract class ElectricityBill
    {
        public abstract void calcbill();
        public abstract void display();


    }


    public class Ebill : ElectricityBill
    {
        int cost = 0, units = 0, charge = 0, due = 0, temp=0;
        int custID;
        string custName;
        public override void calcbill()
        {
            

            Console.WriteLine("Enter Customer ID");
            custID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name");
            custName = Console.ReadLine();

            Console.WriteLine("Enter units used");
            units = Convert.ToInt32(Console.ReadLine());

            if(units <= 100)
            {
                charge = 1;
                cost = units * charge + due;

            }
            else
                if((units >100) &&(units <= 200))
                  {
                     temp = units - 100;
                     charge = temp * 2;
                     cost = 100 + charge + due;

                 }
            else
                if((units >200) &&(units <=300))
                 {
                     temp = units - 200;
                     charge = temp * 3;
                     cost = 300 + charge + due;
                 }
            else
            {
                temp = units - 300;
                charge = temp * 4;
                cost = 600 + charge + due;
            }

            Console.WriteLine("Enter due amount");
            due = Convert.ToInt32(Console.ReadLine());
            

        }

        public override void display()
        {
            Console.WriteLine("****************ELECTRICITY BILL MONTH:APRIL******************");
            Console.WriteLine("Customer ID         : {0}",custID);
            Console.WriteLine("Customer Name       : {0}",custName);
            Console.WriteLine("------------------------------------\n");
            Console.WriteLine("Number of Units     : {0}",units);
            Console.WriteLine("Unit Charge         : 1.Rs");
            Console.WriteLine("Excess Units Charge : {0}",charge);
            Console.WriteLine("Due Amount          : {0}", due);
            Console.WriteLine("                    --------------");
            Console.WriteLine("Total Amount        : {0}", cost);
            Console.WriteLine("                    --------------");

        }

    }

    public class bill
    {
        public static void Main()
        {
            Ebill eb = new Ebill();
            eb.calcbill();
            eb.display();
        }
    }
}
