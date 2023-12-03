using System;
Solution solution = new();
solution.MaxArea(new int[] { 1,8,6,100,5,100,8,3,7 });


public class Solution 
{
    public int MaxArea(int[] height)
    {
        ushort left = 0;
        ushort right = (ushort)(height.Length - 1);

        int result = 0;

        while (left < right)
        {
            bool rightBigger = height[left] < height[right];
            var tempResult = (right - left) * (rightBigger ? height[left] : height[right]);
            result = tempResult > result ? tempResult : result;

            if (rightBigger)
            {
                left++;
            }
            else
            {
                right--;
            }

        }

        return result;
    }

}












// public class Solution {
//     public int MaxArea(int[] height)
//     {
//         IndexValue[] indexValues = new IndexValue[height.Length];
//         for (int i = 0; i < height.Length; i++)
//         
//             indexValues[i] = new IndexValue(height[i], i);
//         }

//         Array.Sort(indexValues);

//         int result = 0;
//         for (int i = indexValues.Length-1; i - 1 >= 0; i--)
//         {
//             var temp = Math.Abs(indexValues[i].Index - indexValues[i-1].Index) * 
//             (indexValues[i].Value > indexValues[i-1].Value ? indexValues[i-1].Value : indexValues[i].Value);
//             result = result > temp ? result : temp;
//         }

//         // for (int i = 0; i < height.Length; i++)
//         // {
//         //     for (int j = i + 1; j < height.Length; j++)
//         //     {
//         //         var temp = (j - i) * (height[i] < height[j] ? height[i] : height[j]);
//         //         result = result > temp ? result : temp;
//         //     }
//         // }

//         return result;
//     }


//     public struct IndexValue : IComparable<IndexValue>
//     {
//         public int Value;
//         public int Index;

//         public IndexValue(int value, int index)
//         {
//             Value = value;
//             Index = index;
//         }

//         public int CompareTo(IndexValue other)
//         {
//             if (this.Value > other.Value) {return 1;}
//             else if (this.Value < other.Value) {return -1;}
//             else {return 0;}
//         }
//     }
// }