public class Solution {
    public string[] SortPeople(string[] names, int[] heights) 
    {
        var comparer = Comparer<int>.Create((first, second) => second - first);
        Array.Sort(heights, names, comparer);
        return names;
    }
}