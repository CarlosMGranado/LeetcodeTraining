public class Solution {
    public int RepeatedNTimes(int[] nums) {
        var seen = new HashSet<int>();
        foreach (var x in nums) {
            if (!seen.Add(x)) {
                return x;
            }
        }
        return -1;
    }
}