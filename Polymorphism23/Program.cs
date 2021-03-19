using System;

namespace Polymorphism23
{
    public class Employee
    {
        public string FirstName = "Fn";
        public string LastName = "Ln";
        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " -PartTime");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " -FullTime");
        }
    }
    public class TemporaryTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " -TemporaryTimeTime");
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            /// PolyMorphism Basically enables us to invoke derived class Methods Using Base Class Refercence Variable at RunTime
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryTimeEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }
}
