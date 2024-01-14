Solution solution = new();
solution.ReorderList(new(1, new(2, new(3, new(4, new(5))))));


public class Solution 
{
    public void ReorderList(ListNode head)
    {
        Stack<ListNode> stack = new();
        Queue<ListNode> queue = new();

        while (head != null)
        {
            stack.Push(head);
            queue.Enqueue(head);
            head = head.next;
        }
        
        head = queue.Dequeue();
        var current = head;
        int i = 1;
        int limit = stack.Count;
        while (i <= limit)
        {
            current.next = stack.Pop();
            current = current.next;
            i++;

            if (i > limit) { break; }

            current.next = queue.Dequeue();
            current = current.next;
            i++;
        }

        current.next = null;

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