public class Solution
{
    public int MaximizeExpressionOfThree(int[] nums)
    {

        int max1 = int.MinValue; // largest
        int max2 = int.MinValue; // second largest
        int min1 = int.MaxValue; // smallest

        foreach (int x in nums)
        {
            if (x <= min1) 
            {
                min1 = x;
            }

            if (x >= max1)
            {
                max2 = max1;
                max1 = x;
            }
            else if (x > max2)
            {
                max2 = x;
            }
        }

        return max1 + max2 - min1;
    }
}
