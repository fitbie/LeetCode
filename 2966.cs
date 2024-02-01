public class Solution {
    public int[][] DivideArray(int[] nums, int k)
    {
        int[][] result = new int[nums.Length / 3][];

        for (int i = 0; i < nums.Length; i++)
        {
            int min = i;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < nums[min]) { min = j; }
            }

            (nums[min], nums[i]) = (nums[i], nums[min]);

            if (i % 3 == 2 && nums[i] - nums[i - 2] > k) { return Array.Empty<int[]>(); }

            result[i / 3] ??= new int[3];

            result[i / 3][i % 3] = nums[i]; 
        }

        return result;
    }
}




// public class Solution {
//     public int[][] DivideArray(int[] nums, int k)
//     {
//         Array.Sort(nums);

//         int[][] result = new int[nums.Length / 3][];

//         int j = 0;
//         for (int i = 0; i < result.Length; i++)
//         {
//             if (nums[j + 2] - nums[j] > k) { return Array.Empty<int[]>(); }

//             result[i] = new int[3];
//             for (int n = 0; n < 3; n++)
//             {
//                 result[i][n] = nums[j];
//                 j++;
//             }
//         }

//         return result;
//     }
// }