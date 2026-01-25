public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        if (k <= 1) return 0;

        Array.Sort(nums);

        int best = int.MaxValue;
        for (int i = 0; i + k - 1 < nums.Length; i++) {
            int diff = nums[i + k - 1] - nums[i];
            if (diff < best) best = diff;
        }

        return best;
    }
}
