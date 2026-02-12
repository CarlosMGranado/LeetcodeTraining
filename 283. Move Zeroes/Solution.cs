public class Solution {
    public void MoveZeroes(int[] nums) {
        int currentIndex = 0;
        for(int i = 0;i<nums.Length;i++)
        {
            if(nums[i]!=0)
            {
                nums[currentIndex] = nums[i];
                currentIndex++;
            }
        }
        for (int i = currentIndex; i < nums.Length; i++) {
            nums[i] = 0;
        }
    }
}