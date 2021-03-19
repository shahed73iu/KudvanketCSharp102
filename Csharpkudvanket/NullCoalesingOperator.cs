using System;

namespace Csharpkudvanket
{
    class NullCoalesingOperator
    {
        static void Main(string[] args)
        {
            int? TicketsOnSale = null;
            int availableTickets = TicketsOnSale ?? 0; //This is Null Coalesing Operator
            Console.WriteLine(availableTickets);
        }
    }
}
