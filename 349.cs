Solution solution = new();
solution.Intersection(new int[] {3,4,2,2,2,2,2,1,4}, new int[] { 1,6,2,2,2,2,5,4,3,9,3 });

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) 
    {
        return nums1.Intersect(nums2).ToArray();
    }
}


// public class Solution {
//     public int[] Intersection(int[] nums1, int[] nums2) 
//     {
//         HashSet<int> second = new(nums2);
//         HashSet<int> result = new();

//         foreach (var i in nums1)
//         {
//             if (second.Contains(i) && !result.Contains(i))
//             {
//                 result.Add(i);
//             }
//         }

//         return result.ToArray();
//     }
// }