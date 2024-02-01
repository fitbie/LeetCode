Solution solution = new();
solution.FindDuplicate(new int[] { 13,46,8,11,20,17,40,13,13,13,14,1,13,36,48,41,13,13,13,13,45,13,28,42,13,10,15,22,13,13,13,13,23,9,6,13,47,49,16,13,13,39,35,13,32,29,13,25,30,13 });


public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        int slow = nums[0];
        int fast = nums[0];

        do
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        while (slow != fast);

        slow = nums[0];

        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }

        return slow;
    }
}


// Bits solution.

// public class Solution
// {
//     public int FindDuplicate(int[] nums)
//     {
//         int result = 0;
//         int[] bitmasks = new int[3126];
        
//         for (int i = 0; i < nums.Length; i++)
//         {
//             int maskIndex = nums[i] / 32;

//             if ((bitmasks[maskIndex] & (1 << nums[i])) == 0)
//             {
//                 bitmasks[maskIndex] |= 1 << nums[i];
//             }
//             else
//             {
//                 result = nums[i];
//                 break;
//             }
//         }

//         return result;

//     }
// }
