Solution solution = new();
solution.RearrangeArray(new int[] { 1,-2, -3, -4, 5, 7 });

public class Solution {
    public int[] RearrangeArray(int[] nums) {
        var en = nums.OrderBy((i) => i < 0 ? 1 : -1).ToArray();
        int i = 0;
        int j = 0;
        while (i < nums.Length / 2)
        {
            nums[j] = en[i];
            j++;
            nums[j] = en[i + nums.Length / 2];
            j++;
            i++;
        }


        return nums;
    }
}