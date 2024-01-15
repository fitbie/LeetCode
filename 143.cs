Solution solution = new();
solution.ReorderList(new(1, new(2, new(3, new(4, new(5))))));


public class Solution 
{
    public void ReorderList(ListNode head)
    {
        List<ListNode> nodes = new();

        while (head != null)
        {
            nodes.Add(head);
            head = head.next;
        }
        
        head = nodes[0];
        var current = head;
        int left = 1; // Bc we assighn below.
        int right = nodes.Count - 1;

        while (left <= right)
        {
            current.next = nodes[right];
            right--;
            current = current.next;

            if (left > right) { break; }

            current.next = nodes[left];
            left++;
            current = current.next;
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


// public class Solution 
// {
//     public void ReorderList(ListNode head)
//     {
//         Stack<ListNode> stack = new();
//         Queue<ListNode> queue = new();

//         while (head != null)
//         {
//             stack.Push(head);
//             queue.Enqueue(head);
//             head = head.next;
//         }
        
//         head = queue.Dequeue();
//         var current = head;
//         int i = 1;
//         int limit = stack.Count;
//         while (i <= limit)
//         {
//             current.next = stack.Pop();
//             current = current.next;
//             i++;

//             if (i > limit) { break; }

//             current.next = queue.Dequeue();
//             current = current.next;
//             i++;
//         }

//         current.next = null;

//     }
// }