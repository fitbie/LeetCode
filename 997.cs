public class Solution {
    public int FindJudge(int n, int[][] trust)
    {
        if (trust.Length == 0 && n == 1) { return 1; }

        int[] votes = new int[n];
        int judge = -1;
        HashSet<int> voters = new();

        for (int i = 0; i < trust.Length; i++)
        {
            int voter = trust[i][0];
            int vote = trust[i][1];
            votes[vote - 1]++;

            voters.Add(voter);
            if (judge == -1 || votes[vote - 1] > votes[judge - 1]) { judge = vote; }
        }

        return judge == -1 || voters.Contains(judge) || votes[judge - 1] < n - 1 ? -1 : judge;   
    }
}