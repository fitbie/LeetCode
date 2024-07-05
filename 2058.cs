public class Solution 
{
    public int[] NodesBetweenCriticalPoints(ListNode head) 
    {
        int[] result = [-1,-1];

        int firstPoint = -1;
        int lastPoint = -1;

        int count = 0;
        ListNode? prev = null;
        for (ListNode? current = head; current != null; current = current.next)
        {
            if (prev != null && current.next != null)
            {
                if (current.val > prev.val && current.val > current.next.val) // Maxima
                {
                    CalculateDistance(firstPoint, count);
                    CalculateDistance(lastPoint, count);

                    if (firstPoint  == -1)
                    {
                        firstPoint = count;
                    }
                    else
                    {
                        lastPoint = count;
                    }
                }
                else if (current.val < prev.val && current.val < current.next.val) // Minima
                {
                    CalculateDistance(firstPoint, count);
                    CalculateDistance(lastPoint, count);
                    

                    if (firstPoint  == -1)
                    {
                        firstPoint = count;
                    }
                    else
                    {
                        lastPoint = count;
                    }
                }
            }

            count++;
            prev = current;
        }

        return result;


        void CalculateDistance(int first, int last)
        {
            int distance = Math.Abs(last - first);

            if (first != -1 && last != -1)
            {
                result[0] = result[0] >= 0 && result[0] < distance ? result[0] : distance;
            }

            if (first != -1 && last != -1)
            {
                result[1] = result[1] > distance ? result[1] : distance;
            }
        }
    }
}


public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next = null) 
    {
        this.val = val;
        this.next = next;
    }
}