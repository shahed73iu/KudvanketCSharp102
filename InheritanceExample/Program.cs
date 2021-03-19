using System;

namespace InheritanceExample
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        double YearlySalary;
        public FullTimeEmployee(double ySalary)
        {
            YearlySalary = ySalary;
        }
        public void salaryReview()
        {
            Console.WriteLine(YearlySalary);
        }
    }
    public class PartTimeEmployee : Employee
    {
        double HourlySalary;
        static int days = 30 * 12;
        public PartTimeEmployee(double hSalary)
        {
            HourlySalary = hSalary;
        }
        public void YearsalaryReviewParttime()
        {
            Console.WriteLine(days * HourlySalary);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee(500000.45);
            PartTimeEmployee PTE = new PartTimeEmployee(65.556);

            FTE.FirstName = "Emam Uddin";
            FTE.LastName = "Shahed";
            FTE.PrintFullName();
            FTE.salaryReview();
            
            PTE.FirstName = "Shafiul Azam";
            PTE.LastName = "Shawon";
            PTE.PrintFullName();
            PTE.YearsalaryReviewParttime();


        }
    }
}
