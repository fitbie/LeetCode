Solution solution = new();
solution.FindMin(new int[] { 3,4,5,1,2 });


public class Solution {
    public int FindMin(int[] nums)
    {
        int last = nums.Length;
        int first = -1;
        int cycleLast = nums.Length - 1;

        while (first < last - 1)
        {
            int middle = (last + first) / 2;
            if (nums[middle] < nums[cycleLast]) { break; }

            if (nums[middle] < nums[^1]) { last = middle; }
            else if (nums[middle] > nums[^1]) { first = middle; }
            cycleLast = middle;
        }
        
        return nums[(cycleLast + 1) % nums.Length];
    }
}