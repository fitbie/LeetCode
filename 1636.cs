public class Solution {
    public int[] FrequencySort(int[] nums) 
    {
        Dictionary<int, int> frequencies = new();

        foreach (var i in nums)
        {
            if (!frequencies.TryAdd(i, 1))
            {
                frequencies[i]++;
            }
        }

        return nums.OrderBy(n => frequencies[n]).ThenByDescending(n => n).ToArray();
    }
}