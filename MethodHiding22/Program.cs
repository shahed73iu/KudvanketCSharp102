using System;

namespace MethodHiding22
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
           // base.PrintFullName(); // (Type-1) child class e thaka obosthay ami base class er ei method ta invoke korte chai
            Console.WriteLine(FirstName + " " + LastName + " -Contractor");
        }

           
    }
    public class FullTimeEmployee : Employee
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            /// This Is Method Hiding technique
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "FullTime";
            FTE.LastName= "Employee";
            FTE.PrintFullName();

            // Employee PTE = new PartTimeEmployee(); //  (Type-2) employee Class er instance banaisi Child class type er
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "PartTime";
            PTE.LastName = "Employee";
            ((Employee)PTE).PrintFullName(); //  (Type-3) TypeCast korlam Object ta k


        }
    }
}
