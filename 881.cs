Solution solution = new();
solution.NumRescueBoats([3,2,2,1], 3);


public class Solution {
    public int NumRescueBoats(int[] people, int limit) 
    {
        int result = 0;
        Array.Sort(people);

        for (int l = 0, r = people.Length - 1; l <= r; l++, r--)
        {
            result++;
            while (limit - people[l] < people[r] && l < r) { result++; r--; }
        }

        return result;
    }
}