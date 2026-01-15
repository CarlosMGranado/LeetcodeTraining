public class Solution {
    public bool IsPossibleToSplit(int[] nums) {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int num in nums) {
            counts.TryGetValue(num, out int c);
            c++;
            if (c > 2) return false;
            counts[num] = c;
        }

    return true;
    }
}