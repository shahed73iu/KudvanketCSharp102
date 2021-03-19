namespace LeetCode283MoveZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };

            int cnt = 0;
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    cnt++;
                }
            }
            if (cnt > 0) 
            {
                for (int i = 0; i <= nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {

                        if (nums[i] < nums[j])
                        {
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }
            }
            

            
            int tempp = 0;
            for (int i = 0; i < nums.Length - cnt - 1; i++)
            {
                for (int j = i + 1; j < nums.Length - cnt; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        tempp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = tempp;
                    }
                }
            }
            System.Console.Write($"[{string.Join(",", nums)}]");
        }
    }
}


//System.Console.Write("[");
//for (int i = 0; i < intArray.Length; i++)
//{
//    System.Console.Write(intArray[i]);
//    System.Console.Write(" ");
//}
//System.Console.Write("]");