Solution solution = new();
solution.MinimumLength("cabaabac");


public class Solution {
    public int MinimumLength(string s) 
    {
        int counter = 0;

        int l = 0;
        int r = s.Length - 1;
        
        while (l < r)
        {
            if (s[l] != s[r]) { break; }
            
            int prevL = l;
            while (s[l + 1] == s[l] && l < r)
            {
                l++;
            }

            int prevR = r;
            while (s[r - 1] == s[r] && l < r )
            {
                r--;
            }

            counter = l - prevL + r - prevR;
        }

        return s.Length - counter;
    }
}