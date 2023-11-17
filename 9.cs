public class Solution {
    public bool IsPalindrome(int x) {
        int old = x;
        int inverse = 0;
        while (x > 0)
        {
            inverse = inverse * 10 + x % 10;
            x /= 10;
        }
        return (old == inverse);
    }
}

