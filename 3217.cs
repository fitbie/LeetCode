public class Solution {
    public ListNode ModifiedList(int[] nums, ListNode head) 
    {
        HashSet<int> numsSet = new(nums);

        Traverse(head, null);

        void Traverse(ListNode? current, ListNode? prev)
        {
            if (current == null)
            {
                return;
            }

            if (numsSet.Contains(current.val))
            {
                if (prev == null) // Means it current was head, select new head.
                {
                    head = current.next;
                    Traverse(current.next, null);
                }
                else
                {
                    prev.next = current.next;
                    Traverse(current.next, prev);
                }

                return;
            }

            Traverse(current.next, current);
        }

        return head;

        // for (ListNode? current = head, prev = null; current != null; prev = current, current = current.next)
        // {
        //     if (numsSet.Contains(current.val))
        //     {
        //         if (prev == null) // We 
        //         {
        //             result = 
        //         }
        //     }
        // }
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