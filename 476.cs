using System.Numerics;

Solution solution = new();
solution.FindComplement(5);

public class Solution 
{
    public int FindComplement(int num) 
    {
        int pow = (int)BitOperations.RoundUpToPowerOf2((uint)num) - 1;
        return (~num) & pow;
    }
}