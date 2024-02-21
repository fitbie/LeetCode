Solution solution = new();
solution.RangeBitwiseAnd(3, 5);


public class Solution 
{
    public int RangeBitwiseAnd(int left, int right) {
        int result = left & right;
        string binary = Convert.ToString(result, 2);

        for (int i = binary.Length - 1; i >= 0; i--)
        {
            if (binary[i] == '1')
            {
                int next = right ^ (1 << binary.Length - i - 1);
                if (next >= left && next <= right)
                {
                    result &= ~(1 << (binary.Length - i - 1));
                }
            }
        }

        return result;
    }
}


// public class Solution 
// {
//     public int RangeBitwiseAnd(int left, int right) {
//         int result = left & right;
//         string binary = Convert.ToString(result, 2);

//         int i = result - 1;
//         while (i >= 0)
//         {
//             {
//                 int next = (result & ~(1 << (binary.Length - i - 1))) | (1 << (binary.Length - i));

//                 if (next >= left && next <= right)
//                 {
//                     i--;
//                     result &= ~(1 << (binary.Length - i - 1));
//                 }
//             }
//         }

//         return result;
//     }
// }
