public class Solution {
    public string[] FindRelativeRanks(int[] score) 
    {
        var scoreRanks = score.ToDictionary(k => k, v => v.ToString());

        int counter = 1;
        foreach(var scr in score.OrderByDescending(k => k))
        {
            scoreRanks[scr] = counter switch
            {
                1 => "Gold Medal",
                2 => "Silver Medal",
                3 => "Bronze Medal",
                _ => counter.ToString()
            };

            counter++;
        }

        return [.. scoreRanks.Values];
    }
}