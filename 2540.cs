public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) 
    {
        int fPointer = 0;
        int sPointer = 0;

        for (; fPointer < nums1.Length; fPointer++)
        {
            while (sPointer < nums2.Length && nums2[sPointer] <= nums1[fPointer])
            {
                if (nums2[sPointer] == nums1[fPointer]) { return nums2[sPointer]; }
                sPointer++;
            }
        }

        return -1;    
    }
}



// public class Solution {
//     public int GetCommon(int[] nums1, int[] nums2) 
//     {
//         HashSet<int> second = new(nums2);

//         for (int i = 0; i < nums1.Length; i++)
//         {
//             if (second.Contains(nums1[i])) { return nums1[i]; }
//         }

//         return -1;    
//     }
// }



// public class Solution {
//     public int GetCommon(int[] nums1, int[] nums2) 
//     {
//         for (int i = 0; i < nums1.Length; i++)
//         {
//             int current = nums1[i];

//             for (int j = 0; nums1[j] <= current && j < nums2.Length; j++)
//             {
//                 if (nums2[j] == current) { return current; }
//             }
//         }

//         return -1;    
//     }
// }