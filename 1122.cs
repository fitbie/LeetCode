public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        Dictionary<int, int> positions = new();

        for (int i = 0; i < arr2.Length; i++)
        {
            positions.Add(arr2[i], i);
        }

        return arr1.OrderBy((i) => positions.ContainsKey(i) ? positions[i] : i + arr2.Length).ToArray();
    }

}