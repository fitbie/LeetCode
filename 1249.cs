using System.Text;

public class Solution {
    public string MinRemoveToMakeValid(string s) 
    {
        Stack<(char, int)> parentheses = new();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsPunctuation(s[i]))
            {
                if (parentheses.TryPeek(out var ps) && Valid(ps.Item1, s[i])) { parentheses.Pop(); }
                else { parentheses.Push((s[i], i)); }
            }
        }

        bool Valid(char first, char second)
        {
            if (first == '(') { return second == ')'; }
            return false;
        }

        var sb = new StringBuilder(s);
        foreach (var e in parentheses)
        {
            sb.Remove(e.Item2, 1);
        }

        return sb.ToString();
    }
}