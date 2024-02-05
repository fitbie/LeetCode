Solution solution = new();
solution.MinWindow("acbbaca", "aba");


public class Solution {
    public string MinWindow(string s, string t) 
    {
        string result = string.Empty;
        if (s.Length < t.Length) { return result; }

        Dictionary<char, int> nonClosed = new();
        foreach (var c in t)
        {
            if (!nonClosed.ContainsKey(c))
            {
                nonClosed.Add(c, 0);
            }
            nonClosed[c]++;
        }

        var leftovers = nonClosed.ToDictionary((k) => k.Key, (v) => 0);
        int startIndex = -1;

        for (int i = 0; i < s.Length; i++)
        {
            char current = s[i];
            if (!nonClosed.ContainsKey(current)) { continue; }

            if (startIndex == -1) { startIndex = i; }

            if (nonClosed[current] > 0)
            {
                nonClosed[current]--;
            }
            else
            {
                leftovers[current]++;

                while (leftovers[s[startIndex]] > 0)
                {
                    leftovers[s[startIndex]]--;
                    startIndex++;
                    while (!leftovers.ContainsKey(s[startIndex]))
                    {
                        startIndex++;
                    }
                }
            }

            if (nonClosed.Values.All((j) => j == 0)) 
            {
                string preResult = s[startIndex..(i+1)];
                if (result == "") { result = preResult; }
                else { result = preResult.Length < result.Length ? preResult : result; }
            }

        }

        return result;
    }
}



// public class Solution {
//     public string MinWindow(string s, string t) 
//     {
//         string result = string.Empty;
//         if (s.Length < t.Length) { return result; }
//         List<(char c, int i)> values = new();

//         for (int i = 0; i < s.Length; i++)
//         {
//             if (t.Contains(s[i]))
//             {
//                 values.Add((s[i], i));
//             }
//         }
        
//         if (values.Count == 0 || values.Count < t.Length) { return result; }
        
//         string nonClosed = t;
//         string leftOver = "";
//         int startIndex = 0;
//         for (int i = 0; i < values.Count; i++)
//         {
//             char current = values[i].c;
//             if (nonClosed.Contains(current))
//             {
//                 nonClosed = nonClosed.Remove(nonClosed.IndexOf(current), 1);
//             }
//             else
//             {
//                 leftOver += values[i].c;

//                 while (leftOver.Contains(values[startIndex].c))
//                 {
//                     leftOver = leftOver.Remove(leftOver.IndexOf(values[startIndex].c), 1);
//                     startIndex++;
//                 }


//             }
//             if (string.IsNullOrEmpty(nonClosed)) 
//             {
//                 string preResult = s[values[startIndex].i..(values[i].i + 1)];
//                 if (result == "") { result = preResult; }
//                 else { result = preResult.Length < result.Length ? preResult : result; }
//             }

//         }

//         // result = endIndex == -1 ? result : s[values[startIndex].i..++endIndex];

//         return result;
//     }
// }