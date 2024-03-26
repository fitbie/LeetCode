public class Solution {
    public int FirstMissingPositive(int[] nums) 
    {
        HashSet<int> ints = new(nums);

        int i = 0;
        while (true)
        {
            if (!ints.Contains(++i)) { return i; }
        }
        
    }
}