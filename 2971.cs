Solution solution = new();
solution.LargestPerimeter(new int[] { 1,12,1,2,5,50,3 });


public class Solution 
{
    public long LargestPerimeter(int[] nums) 
    {
        Array.Sort(nums);

        long result = 0;
        long tempResult = 0;
        int sides = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (tempResult <= nums[i])
            {
                tempResult += nums[i];
            }
            else
            {
                sides += i + 1;
                tempResult += nums[i];
                result = tempResult;
            }
        }        

        result = result == 0 || sides < 3 ? -1 : result;
        return result;
    }
}