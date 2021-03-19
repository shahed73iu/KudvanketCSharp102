using System;

namespace PracticeMyself__BaseConstructorInitialize
{
    class Program
    {
        static void Main(string[] args)
        {
            ////var redius = 2.5;
            ////var height = 3.0;
            ////Circle ring = new Circle(redius);
            ////Cylinder tube = new Cylinder(redius, height);
            ////Console.WriteLine("Area of the Circle =  {0:F2}", ring.Area());
            ////Console.WriteLine("Area of the Cylinder = {0:F2}",tube.Area());
            ////Console.WriteLine("Please Enter Any Key to exit");
            ////Console.ReadKey();
            var MyName = "shahed";
            Location l = new Location(MyName);
            Console.WriteLine(l.Name);
            int x;
        }
    }
    public class Location
    {
        private string locationName;
        public string Name { get; set; }

        public Location(string name) => Name = name;
        //public string Name
        //{
        //    get => locationName;
        //    set => locationName = value;
        //}
    }
    abstract class Shape
    {
        public const double pi = Math.PI;
        protected double x, y;
        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract double Area();
    }
    class Circle : Shape
    {
        public Circle(double redius) 
            :base(redius,0)
        {

        }

        public override double Area()
        {
            return pi * x * x;
        }
    }
    class Cylinder : Circle
    {
        public Cylinder(double redious, double height)
            :base(redious)
        {
            y = height;
        }
        public override double Area()
        {
            return (2* base.Area() + 2*pi*x*y);
        }
    }
}
