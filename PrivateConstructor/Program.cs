using System;

namespace PrivateConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter.CurrentCount = 100;
            var x = Counter.IncrementCount();
            Console.WriteLine("New Count: {0}",x);
        }
    }
    public class Counter
    {
        private Counter() { }
        public static int CurrentCount;
        public static int IncrementCount()
        {
            return ++CurrentCount;
        }
    }

}
