public class Solution
{
    public ListNode MergeNodes(ListNode head) 
    {
        // This is our pointer to existing LL. We do this litle trick instead of simple 'result = head',
        // because in the end of evaluation we need trim unused nodes. To make our life easier, every node
        // update we FIRSTLY do 'result = result.next', and then update node's value. So, for the first 
        // iteration we need result.next be head node. 
        ListNode result = new() { next = head };
        int prefixSum = 0;

        for (ListNode current = head.next; current != null; current = current.next)
        {
            if (current.val > 0)
            {
                prefixSum += current.val;
            }
            else
            {
                result = result.next;
                result.val = prefixSum;
                prefixSum = 0;
            }
        }

        // Trim end. Because we do little trick in the beginnin, our result point to actual end of resulting LL,
        // not the next. So we just set next to null and return head.
        result.next = null;
        return head;
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