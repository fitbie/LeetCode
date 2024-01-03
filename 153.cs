Solution solution = new();
solution.FindMin(new int[] { 2, 1 });


public class Solution {
    public int FindMin(int[] nums)
    {
        if (nums.Length == 0) { return nums[0]; }

        int last = nums.Length;
        int first = -1;
        int cycleLast = nums.Length - 1;

        if (nums[0] > nums[^1])
        {
            while (first < last - 1)
            {
                int middle = (last + first) / 2;

                if (nums[middle] < nums[^1]) { last = middle; }
                else if (nums[middle] > nums[^1]) { first = middle; }
                else if (nums[middle] == nums[^1]) { break; }
                cycleLast = nums[cycleLast] > nums[middle] ? cycleLast : middle;
            }
        }
        
        return nums[(cycleLast + 1) % nums.Length];
    }
}