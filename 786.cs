public class Solution {
    public int[] KthSmallestPrimeFraction(int[] arr, int k)
    {
        SortedDictionary<double, int[]> sortedValues = new();

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                sortedValues.Add(arr[i] / (double)arr[j], [arr[i], arr[j]]);
            }
        }

        return sortedValues.Skip(k - 1).First().Value;
    }
}