public class Solution {
    public int MissingNumber(int[] nums)
    {
        int rightSum = 0;
        int currSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            rightSum += i + 1;
            currSum += nums[i];
        }

        return rightSum - currSum;
    }


    // public int MissingNumber(int[] nums) 
    // {
    //     HashSet<int> ints = new(nums);

    //     for (int i = 0; i <= nums.Length; i++)
    //     {
    //         if (!ints.Contains(i)) { return i; }
    //     }    

    //     return -1;
    // }

}