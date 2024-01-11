 
Solution solution = new();
var result = solution.ReverseList(new(1, new(2, new(3, new(4, new(5))))));
var node = result;
while (node.next != null)
{
    Console.WriteLine(node.next.val);
    node = node.next;
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


public class Solution {
    public ListNode ReverseList(ListNode head)
    {
        if (head?.next == null) { return head; }

        // ListNode node = head;
        // while (node.next != null)
        // {
        //     node.val = node.next.val;
        //     node = node.next;
        // }

        // return head;

        ListNode last = head;
        Reverse(head.next, head);
        head.next = null;

        void Reverse(ListNode current, ListNode prev)
        {
            if (current.next != null) { Reverse(current.next, current); }
            else
            {
                last = current;
            }
            current.next = prev;
            return;
        }

        return last;
    }
}