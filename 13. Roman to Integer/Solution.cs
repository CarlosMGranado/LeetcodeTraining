public class Solution {
    public int RomanToInt(string s) {
        var romanValue = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },         
        };

        int result = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int current = romanValue[s[i]];

            if (i != 0)
            {
                int previous = romanValue[s[i - 1]];
                if (previous < current)
                {
                    result += current - previous;
                    i--;
                    continue;
                }
            }

            result += current;
        }

        return result;
    }
}
