public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (numbers[left] + numbers[right] != target) // There SHOULD be one solution.
        {
            if (numbers[left] + numbers[right] > target) { right--; }
            if (numbers[left] + numbers[right] < target) { left++; }
        }

        return new int[] { left + 1, right + 1 };
    }
}