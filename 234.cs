public class ListNode {     
    public int val;     
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    } 
}
 
public class Solution
{
    public bool IsPalindrome(ListNode head) 
    {
        List<int> values = new();
        while (head != null)
        {
            values.Add(head.val);
            head = head.next;
        }

        int r = values.Count - 1;
        for (int l = 0; l < r; l++, r--)
        {
            if (values[l] != values[r]) { return false; }
        }

        return true;
    }
}