Solution solution = new();
solution.MergeTwoLists(new(1,new(3,new(5,new(6, null)))), new(1,new(2,new(4,new(7, null)))));


public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null) { return null; }

        ListNode result = new();
        ListNode current = result;
        ListNode pointer1 = list1;
        ListNode pointer2 = list2;

        while (pointer1 != null && pointer2 != null)
        {
            if (pointer1.val <= pointer2.val)
            {
                current.val = pointer1.val;
                current.next = new();
                current = current.next;
                pointer1 = pointer1.next;
            }
            else 
            {
                current.val = pointer2.val;
                current.next = new();
                current = current.next;
                pointer2 = pointer2.next;
            }
        }

        if (pointer1 != null)
        {
            current.val = pointer1.val;
            current.next = pointer1.next;
        }

        if (pointer2 != null)
        {
            current.val = pointer2.val;
            current.next = pointer2.next;
        }
        
        return result;
    }
}


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}
