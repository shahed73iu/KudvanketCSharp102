using System;

namespace Csharpkudvanket
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
}


#region TryParse
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Csharpkudvanket
//{
//    class Program
//    {
//        /// <summary>
//        ///  TryParse and Parse Method in
//        /// </summary>
//        /// <param name="args"></param>
//        static void Main(string[] args)
//        {
//            string strNumber = "9987";
//            int Result = 0;
//            string strMessage = "Please enter a valid number";
//            var IsConversionSuccessfull = int.TryParse(strNumber, out Result);
//            var x = IsConversionSuccessfull ? Result.ToString() : strMessage;
//            Console.WriteLine(x);
//        }
//    }
//}

#endregion
#region Static and instance method 
/* using System;

namespace Csharpkudvanket
{
   class Program
   {
       static void Main(string[] args)
       {
           var p = new Program();
           p.EvenNumber();
           p.EvenNumber();
           shahed.odd();
       }

       public void EvenNumber()
       {
           int start = 0;
           while (start <= 20)
           {
               Console.WriteLine(start);
               start = start + 2;
           }
       }
   }
   class shahed 
   {
       public static void odd()
       {
           int start = 0;
           while (start <= 20)
           {
               Console.WriteLine(start);
               start = start + 2;
           }
       }
   }
}


#region TryParse
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Csharpkudvanket
//{
//    class Program
//    {
//        /// <summary>
//        ///  TryParse and Parse Method in
//        /// </summary>
//        /// <param name="args"></param>
//        static void Main(string[] args)
//        {
//            string strNumber = "9987";
//            int Result = 0;
//            string strMessage = "Please enter a valid number";
//            var IsConversionSuccessfull = int.TryParse(strNumber, out Result);
//            var x = IsConversionSuccessfull ? Result.ToString() : strMessage;
//            Console.WriteLine(x);
//        }
//    }
//}

#endregion
*/
#endregion
#region A class with two class constructors, one without arguments and one with two arguments.
/*
 using System;

namespace Csharpkudvanket
{
    class Program
    {
        static void Main(string[] args)
        {
            var p2 = new Coords(5, 3);
            var p1 = new Coords();

            // Display the results using the overriden ToString method.
            Console.WriteLine($"Coords #1 at {p1}");
            Console.WriteLine($"Coords #2 at {p2}");
            Console.ReadKey();
        }

    }
}
 */
#endregion
#region A parameterless constructor is automatically provided and the fields are initialized to their default values.
/*
    using System;

namespace Csharpkudvanket
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            Console.WriteLine($"Name: {person.name}, Age: {person.age}");
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
        }

    }
    public class Person
    {
        public int age;
        public string name;
    }

}
 */
#endregion
