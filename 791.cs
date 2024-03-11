using System.Text;

Solution solution = new();
Console.WriteLine(solution.CustomSortString("cba", "abcd"));

// LINQ
public class Solution {
    public string CustomSortString(string order, string s) 
    {
        return string.Concat(s.OrderBy(order.IndexOf).ToArray());
        
    }
}


// public class Solution {
//     public string CustomSortString(string order, string s) 
//     {
//         Dictionary<char, int> positions = new();
//         for (int i = 0; i < order.Length; i++)
//         {
//             positions.Add(order[i], i);
//         }

//         StringBuilder sb = new()
//         {
//             Length = s.Length
//         };

//         StringBuilder leftovers = new();
//         for (int i = 0; i < s.Length; i++)
//         {
//             if (positions.TryGetValue(s[i], out var pos))
//             {
//                 if (sb[pos] == 0) { sb[pos] = s[i]; }
//                 else { sb[pos + 1] = s[i]; }
//             }
//             else
//             {
//                 leftovers.Append(s[i]);
//             }
//         }

//         for(int i = 0; i < leftovers.Length; i++)
//         {
//             sb.Append(leftovers[i].ToString());
//         } 

//         return sb.ToString();
//     }
// }