public class Solution 
{
    public ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        Traverse(null, head);

        return head;

        void Traverse(ListNode? prev, ListNode? current)
        {
            if (current == null)
            {
                return; // End of LL
            }

            if (prev != null)
            {
                prev.next = new(GCD(prev.val, current.val), current);
            }

            Traverse(current, current.next);
        }


        int GCD(int x, int y)
        {
            while (x != 0 && y != 0)
            {
                if (x > y) x %= y;
                else y %= x;
            }

            return x | y;
        }
    }
}


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}