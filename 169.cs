public class Solution {
    public int MajorityElement(int[] nums)
    {
        int majority = nums.Length / 2;

        Dictionary<int, int> count = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int current = nums[i];
            if (!count.ContainsKey(nums[i]))
            {
                count.Add(current, 0);
            }

            count[current]++;
            if (count[current] > majority) { return current; }
        }    


        return count.First((kv) => kv.Value > majority).Key;
    }
}