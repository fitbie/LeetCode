public class Solution {
    public void ReverseString(char[] s) 
    {
        int left = 0;    
        int right = s.Length - 1;

        while (left < right)
        {
            (s[right], s[left]) = (s[left], s[right]);
            left++;
            right--;
        }
    }
}