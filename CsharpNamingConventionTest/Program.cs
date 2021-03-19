using System;
using System.Text;
using System.Threading;

namespace CsharpNamingConventionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
            var manyPhrases = new StringBuilder();
            for (var i = 0; i < 10000; i++)
            {
                manyPhrases.Append(phrase);
                Console.WriteLine("tra" + manyPhrases);
                Thread.Sleep(1000);
            }
        }
    }
}
