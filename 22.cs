// Solution solution = new();
// foreach (var s in solution.GenerateParenthesis(3))
// {
//     Console.WriteLine(s);
// }


public class Solution 
{
    public IList<string> GenerateParenthesis(int n)
    {
        IList<string> result = new List<string>();
        HashSet<string> cashed = new();

        string initial = "(";
        FindCombinations(initial);

        void FindCombinations(string current)
        {
            if (current.Length == 0) { return; }

            cashed.Add(current);

            if (current.Length >= n * 2) // Final node
            {
                if (IsValidParenthesis(current)) { result.Add(current); }
                FindCombinations(current.Remove(current.Length-1));
            }
            else
            {
                if (!cashed.Contains(current + '(') && current.Count((c) => c == '(') != n)
                { FindCombinations(current + '('); }

                else if (!cashed.Contains(current + ')') && current.Count((c) => c == ')') != n) 
                { FindCombinations(current + ')'); }

                else FindCombinations(current.Remove(current.Length-1));
            }
        }

        return result;
    }



    private bool IsValidParenthesis(string s)
    {
        if (s.Length == 1) { return false; }

        Stack<char> parenthesis = new();
        foreach (var bracket in s)
        {
            if (bracket == '(')
            {
                parenthesis.Push(bracket);
            }
            else
            {
                if (!parenthesis.TryPop(out var _)) { return false; }
            }
        }

        return parenthesis.Count == 0;
    }

}