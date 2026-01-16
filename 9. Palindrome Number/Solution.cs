public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0) return false;
        string initialX = x.ToString();
        string reverseX = new string(initialX.Reverse().ToArray());
        return x.ToString() == reverseX;

    }
}