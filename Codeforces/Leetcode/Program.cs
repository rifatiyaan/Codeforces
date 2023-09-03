public class Leetcode
{
    public void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine(RemoveElement(numbers, 3));


        int RemoveElement(int[] nums, int val)
        {
            int current = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[current] = nums[i];
                    current++;
                }
            }
            return current;
        }
    }
}