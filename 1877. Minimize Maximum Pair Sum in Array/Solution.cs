public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        int result = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            int pairSum = nums[i]+nums[nums.Length-i-1];
            if(pairSum>result)
            {
                result = pairSum;
            }
        }
        return result;
    }
}