public class Solution {
    public bool HasCycle(ListNode head) 
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast) { return true; }
        }

        return false;
    }
}






// public class Solution 
// {
//     public bool HasCycle(ListNode head) 
//     {
//         int i = 0;
//         while (i <= 10000)
//         {
//             if (head == null) { return false; }
//             head = head.next;
//             i++;
//         }

//         return true;
//     }
// }


 public class ListNode 
 {
    public int val;
    public ListNode next;
    public ListNode(int x) 
    {
        val = x;
        next = null;
    }
}
 