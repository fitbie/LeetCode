public class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> hashInts = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hashInts.Contains(nums[i])) { return true; }
            hashInts.Add(nums[i]);
        }

        return false;
    }
}



public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        return new HashSet<int>(nums).Count < nums.Length;
    }
}