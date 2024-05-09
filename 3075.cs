public class Solution
{
    public long MaximumHappinessSum(int[] happiness, int k) 
    {
        long result = 0;
        Array.Sort(happiness, (f, s) => s.CompareTo(f));

        for (int i = 0; k > 0; i++, k--)
        {
            result += Math.Max(happiness[i] - i, 0);
        }    

        return result;
    }
}