public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) 
    {
        int p2 = 0;

        for (int p1 = 0; p1 < nums1.Length; p1++)
        {
            while (p2 < nums2.Length && nums2[p2] <= nums1[p1])
            {
                if (nums2[p2] == nums1[p1]) { return nums2[p2]; }
                p2++;
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