public class Solution
{
    public int CountBinarySubstrings(string s)
    {
        var groups = new List<int>();

        char current = s[0];
        int currentCount = 0;

        foreach (char c in s)
        {
            if (c == current)
            {
                currentCount++;
            }
            else
            {
                groups.Add(currentCount);
                current = c;
                currentCount = 1;
            }
        }

        groups.Add(currentCount);

        int result = 0;
        for (int i = 0; i < groups.Count - 1; i++)
        {
            result += Math.Min(groups[i], groups[i + 1]);
        }

        return result;
    }
}
