Solution solution = new();
solution.AddTwoNumbers(new(9,new(9,new(9,new(9)))), new(9,new(9,new(9))));


public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode result = l1;

        Add(l1, l2, 0);

        void Add(ListNode list1, ListNode list2, int modifier)
        {
            list1.val += (list2?.val ?? 0) + modifier;
            modifier = 0;

            // Constaints of problem, we dont need to check 20, 30, etc..
            if (list1.val >= 10) { modifier = 1; list1.val -= 10;  }

            if (list1.next == null && list2?.next == null ) 
            {
                if (modifier > 0) { list1.next = new(modifier); }
                return;
            }

            list1.next ??= new ListNode();

            Add(list1.next, list2?.next, modifier);
        }

        return result;
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