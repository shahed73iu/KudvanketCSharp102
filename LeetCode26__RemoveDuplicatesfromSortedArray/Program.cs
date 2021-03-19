using System;
using System.Collections.Generic;

namespace LeetCode26__RemoveDuplicatesfromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var x = "Shahed";
            s.ReverseString(x);    
        }
    }
    public class Solution
    {
        public void helper(char[] shahed, int l, int r)
        {

        }
        public void ReverseString(char[] s)
        {
            helper(s, 0, s.Length);
        }
    }
    #region FizzBuzz
    //public class Solution
    //{
    //    public void FizzBuzz(int n)
    //    {
    //        List<String> MyList = new List<String>();
    //        for (int i = 1; i <= n; i++)
    //        {
    //            Boolean D3 = (i % 3 == 0);
    //            Boolean D5 = (i % 5 == 0);
    //            if (D3 && D5)
    //            {
    //                MyList.Add("FizzBuzz");
    //            }
    //            else if (D3)
    //            {
    //                MyList.Add("Fizz");
    //            }
    //            else if (D5)
    //            {
    //                MyList.Add("Buzz");
    //            }
    //            else
    //            {
    //                MyList.Add(i.ToString());
    //            }
    //        }
    //        MyList.ForEach(Console.WriteLine);
    //        Console.WriteLine();
    //        // return MyList;
    //    }
    //}
    #endregion
}
