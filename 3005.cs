public class Solution {
    public int MaxFrequencyElements(int[] nums) 
    {
        int result = 0;
        int maxFrequency = 0;
        Dictionary<int, int> freqs = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!freqs.ContainsKey(nums[i]))
            {
                freqs.Add(nums[i], 0);
            }
            freqs[nums[i]]++;

            if (freqs[nums[i]] == maxFrequency) { result += maxFrequency; }
            if (freqs[nums[i]] > maxFrequency) { maxFrequency = freqs[nums[i]]; result = maxFrequency; }
        }

        return result;    
    }
}