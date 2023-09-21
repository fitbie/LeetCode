public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (dict.ContainsKey(diff)) { return new int[] { i, dict[diff] }; }

            else { dict.TryAdd(nums[i], i); }
        }

        return null;
    }
}