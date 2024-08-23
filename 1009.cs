public class Solution {
    public int BitwiseComplement(int n) 
    {
        if (n == 0) { return 1; }
        int pow = (int)BitOperations.RoundUpToPowerOf2((uint)n) - 1;
        return (~n) & pow;
    }
}