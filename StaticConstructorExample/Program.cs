using System;

namespace StaticConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus(71);
            
            Bus bus2 = new Bus(72);
            bus1.Drive();

            System.Threading.Thread.Sleep(10000);

            bus2.Drive();
        }
    }
    public class Bus
    {
        protected static readonly DateTime globalStartTime;
        protected int RouteNumber { get; set; }
        static Bus()
        {
            globalStartTime = DateTime.Now;
            Console.WriteLine("Static Constructor Sets Global Start Time to {0}", globalStartTime.ToLongTimeString());
        }
        public Bus(int routName)
        {
            RouteNumber = routName;
            Console.WriteLine("Bus #{0} is Created.", RouteNumber);
        }
        public void Drive()
        {
            TimeSpan elapsTime = DateTime.Now - globalStartTime;
            Console.WriteLine("Bus {0} is Starting its route {1:F2} miliSeconds after global start time {2}.",
                this.RouteNumber,elapsTime.Milliseconds,globalStartTime.ToLongTimeString());
        }
    }
}
