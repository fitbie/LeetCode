
public class Solution {
    public bool HasCycle(ListNode head) 
    {
        HashSet<ListNode> seen = new();

        while (head != null)
        {
            if (!seen.Contains(head))
            {
                seen.Add(head);
            }
            else
            {
                return true;
            }
            
            head = head.next;
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
 