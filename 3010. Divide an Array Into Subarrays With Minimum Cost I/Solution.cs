public class Solution {
    public int MinimumCost(int[] nums) {
        int[] solution = new int[2] {Int32.MaxValue,Int32.MaxValue};

        foreach(int num in nums.Skip(1))
        {
            if(num < solution[0])
            {
                solution[1] = solution[0];
                solution[0] = num;
                continue; 
            }

            if(num < solution[1])
            {
                solution[1] = num;
                continue;
            }
        }

        return solution[0]+solution[1]+nums[0];
    }
}