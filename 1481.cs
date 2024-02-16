Solution solution = new();
solution.FindLeastNumOfUniqueInts(new int[] { 4,3,1,1,3,3,2 }, 3);

public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) 
    {
        Dictionary<int, int> counts = new();

        foreach (var i in arr)
        {
            if (!counts.ContainsKey(i))
            {
                counts.Add(i, 0);
            }
            counts[i]++;
        }

        var temp = counts.Values.OrderBy((val) => val).ToArray();
        int cur = 0;
        for (; cur < temp.Length && k >= 0;)
        {
            if (temp[cur] > 0)
            {
                temp[cur]--;
                k--;
            }
            else
            {
                cur++;
            }
        }

        return temp.Length - cur;

    }
}