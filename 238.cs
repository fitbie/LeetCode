public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if (nums.Length == 2) { Array.Reverse(nums); return nums; }

        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int element = 1;

            int current = 0;
            while (current < i)
            {
                element *= nums[current];
                current++;
            }
            current = nums.Length-1;
            while(current > i)
            {
                element *= nums[current];
                current--;
            }

            result[i] = element;
        }

        return result;
    }
}