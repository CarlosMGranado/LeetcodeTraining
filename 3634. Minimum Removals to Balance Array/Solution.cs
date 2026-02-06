public class Solution {
     public int MinRemoval(int[] nums, int k)
    {
        Array.Sort(nums);
        int n = nums.Length;

        int maxWindow = 1;
        int left = 0;

        for (int right = 0; right < n; right++)
        {
            while (left <= right && (long)nums[right] > (long)nums[left] * k)
            {
                left++;
            }

            int windowSize = right - left + 1;
            if (windowSize > maxWindow)
            {
                maxWindow = windowSize;
            }
        }

        return n - maxWindow;
    }
}