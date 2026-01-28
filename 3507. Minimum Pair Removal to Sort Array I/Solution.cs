public class Solution
{
    public int MinimumPairRemoval(int[] nums)
    {
        var numbers = new List<int>(nums);
        int operations = 0;

        while (true)
        {
            bool isNonDecreasing = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    isNonDecreasing = false;
                    break;
                }
            }

            if (isNonDecreasing) return operations;

            int bestPairIndex = 0;
            int bestPairSum = numbers[0] + numbers[1];

            for (int i = 1; i < numbers.Count - 1; i++)
            {
                int currentPairSum = numbers[i] + numbers[i + 1];
                if (currentPairSum < bestPairSum)
                {
                    bestPairSum = currentPairSum;
                    bestPairIndex = i;
                }
            }

            numbers[bestPairIndex] = numbers[bestPairIndex] + numbers[bestPairIndex + 1];
            numbers.RemoveAt(bestPairIndex + 1);
            operations++;
        }
    }
}
