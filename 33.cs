Solution solution = new();
solution.Search(new int[] { 5,1,2,3,4 }, 1);

public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        if (nums.Length == 1) { return nums[0] == target ? 0 : -1; }
        if (nums.Length == 2)
        {
            if (nums[0] == target) { return 0; }
            else if (nums[1] == target) { return 1; }
            else return -1;
        }

        int left = -1;
        int right = nums.Length;

        // Find truly last element of cycled shift..
        if (nums[0] > nums[^1])
        {
            int cycledLast = 0;
            while (left < right - 1)
            {
                int middle = (left + right) / 2;

                if (nums[middle] > nums[^1]) { left = middle; }
                if (nums[middle] <= nums[^1]) { right = middle; }
                cycledLast = middle;
            }
            if (target > nums[^1]) { left = -1; right = cycledLast; }
            else if (target < nums[^1]) { left = cycledLast - 1; right = nums.Length; }
            else if (target == nums[^1]) { return nums.Length - 1; }
        }

        while (left < right - 1)
        {
            int middle = (left + right) / 2;

            if (nums[middle] > target) { right = middle; }
            else if (nums[middle] < target) { left = middle; }
            else return middle;
        }

        return -1;
    }
}