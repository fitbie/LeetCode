Solution solution = new();
solution.MinDifference([6,6,0,1,1,4,6]);


public class Solution 
{
    public int MinDifference(int[] nums)
    {
        if (nums.Length <= 4) { return 0; }

        Array.Sort(nums);

        int result = int.MaxValue;

        result = Math.Min(nums[^4] - nums[0], result);
        result = Math.Min(nums[^1] - nums[3], result);
        result = Math.Min(nums[^3] - nums[1], result);
        result = Math.Min(nums[^2] - nums[2], result);
    

        return result;
    }
}