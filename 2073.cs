public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        int time = 0;
        int pointer = 0;
        while (tickets[k] > 0)
        {
            if (tickets[pointer] == 0) { pointer = ++pointer % tickets.Length;; continue; }
            time++;
            tickets[pointer]--;
            pointer = ++pointer % tickets.Length;
        }    

        return time;
    }
}