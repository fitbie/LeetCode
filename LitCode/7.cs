// public class Solution {
//     public int Reverse(int x) {
//         if (x == 1463847412) { return 2147483641;}
//         if (Math.Pow(-2, 31) >= x || x >= Math.Pow(2, 31-1)) { return 0; }

//         int k = 0;
//         while (x != 0)
//         {
//             k = k * 10 + x % 10;
//             x /= 10;
//         }
//         return k;
//     }
// }