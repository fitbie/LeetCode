// Solution solution = new();

// Console.WriteLine(solution.FindMedianSortedArrays(new int[] { 1,4 }, new int[] { 2, 3 }));

// public class Solution {
//     public double FindMedianSortedArrays(int[] nums1, int[] nums2)
//     {
//         var allLength = nums1.Length + nums2.Length;

//         // We are looking for value at this index, or at value between this index and this - 1 index if allLength is even number.
//         int midIndex = allLength / 2;

//         int first = 0; // Pointer for nums1.
//         int second = 0; // Pointer for nums2.

//         int mid = 0; // Value we search for.
//         int prevMid = 0; // In case of even allLength we need to divide (midIndex and midIndex - 1) by 2.  So we save previous midIndex.
        
//         int i = 0; // Number of iterations.

//         while (i <= midIndex)
//         {
//             i++;
//             if (first >= nums1.Length) // If we out of elements in first array - move through second.
//             {
//                 prevMid = mid;
//                 mid = nums2[second];
//                 second++;
//                 continue;
//             }
//             if (second >= nums2.Length) // Same thing.
//             {
//                 prevMid = mid;
//                 mid = nums1[first];
//                 first++;
//                 continue;
//             }

//             // We update our mid variables and move pointer. So we basically doing sorting but without the array.
//             if (nums1[first] < nums2[second])
//             {
//                 prevMid = mid;
//                 mid = nums1[first];
//                 first++;
//             }
//             else
//             {
//                 prevMid = mid;
//                 mid = nums2[second];
//                 second++;
//             }
//         }

        

//         // var all = nums1.Concat(nums2).ToArray();
//         // for (int last = all.Length - 1; last >= midIndex-1; last--)
//         // {
//         //     for (int i = 0; i < last; i++)
//         //     {
//         //         if (all[i] < all[i+1])
//         //         {
//         //             var temp = all[i];
//         //             all[i] = all[i+1];
//         //             all[i+1] = temp;
//         //         }
//         //     }
//         // }

//         return allLength % 2 == 0 ? (mid + prevMid) / 2d : mid;
//     }
// }