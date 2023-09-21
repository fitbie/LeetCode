// public class Solution
// {
// public bool IsValid(string s) {
//     var k = new Stack<char>();

//     foreach (char c in s)
//     {
//         if (c == '[') { k.Push(']'); continue; }
//         if (c == '{') { k.Push('}'); continue; }
//         if (c == '(') { k.Push(')'); continue; }

//         if (k.Count == 0 || c != k.Pop()) { return false; }
//     }    

//     if (k.Count != 0) { return false; }
//     return true;
// }
// }