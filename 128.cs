public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        if (nums.Length == 1) { return 1; }
        if (nums.Length == 0) { return 0; }

        HashSet<int> set = new(nums);

        int tempResult = 1;
        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int temp = nums[i];
            while (set.Contains(temp-1)) { temp--; tempResult++; }

            temp = nums[i];
            while (set.Contains(temp + 1)) { temp++; tempResult++; }

            result = result > tempResult ? result : tempResult;
            tempResult = 1;
        }
        
        result = result > tempResult ? result : tempResult;
        return result;
    }
}