public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int maxCandy = 0;

        foreach (int candy in candies) {
            if (candy > maxCandy) {
                maxCandy = candy;
            }
        }
        List<bool> result = new List<bool>(candies.Length);
        foreach (int candy in candies) {
            result.Add(candy + extraCandies >= maxCandy);
        }

        return result;
    }
}
