public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        IList<IList<int>> result = new List<IList<int>>();
        int minDif = Int32.MaxValue;
        for(int i = 0; i<arr.Length-1;i++)
            {
                if(arr[i+1] -arr[i] < minDif)
                {
                    minDif = arr[i+1] -arr[i];
                }
            }
        for(int i = 0; i<arr.Length-1;i++)
            {
                if(arr[i+1] -arr[i] == minDif)
                    {
                        result.Add(new List<int> { arr[i], arr[i + 1] });
                    } 
            }
        return result;
    }
}