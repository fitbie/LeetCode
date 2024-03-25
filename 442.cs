public class Solution {
    public IList<int> FindDuplicates(int[] nums) 
    {
        HashSet<int> values = new(nums);
        foreach (var n in nums)
        {
            if (!values.Remove(n)) { values.Add(n); }
        }     

        return values.ToArray();
    }
}