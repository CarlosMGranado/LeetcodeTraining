public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        foreach(char letter in letters)
        {
            if(letter > target)
            {
                return letter;
            }
        }
        return letters[0];
    }
}