public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if (nums.Length == 1) return nums;

        Dictionary<int, int> counter = new();
        foreach (var i in nums)
        {
            if (!counter.TryAdd(i, 1))
            {
                counter[i]++;
            }
        }

        int[] result = new int[k];
        int maxKey = 0;
        for (int i = 0; i < k; i++)
        {
            maxKey = counter.MaxBy((keyValue) => keyValue.Value).Key;
            result[i] = maxKey;
            counter.Remove(maxKey);
        }

        return result;
    }
}