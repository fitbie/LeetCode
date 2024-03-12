Solution solution = new();
solution.RemoveZeroSumSublists(new(-1, new(0, new(2, new(-2, new(-2, new(-1, new(1, new(2, new(0))))))))));

 
public class Solution {
    public ListNode RemoveZeroSumSublists(ListNode head) 
    {
        List<int> nodeValues = new();

        Traverse(head);

        void Traverse(ListNode node)
        {
            if (node == null) { return; }

            if (node.val != 0)
            {
                bool find = false;
                int tempSum = 0;
                for (int i = nodeValues.Count - 1; i >= 0; i--)
                {
                    tempSum += nodeValues[i];
                    if (tempSum + node.val == 0)
                    {
                        nodeValues.RemoveRange(i, nodeValues.Count - i);
                        find = true;
                        break;
                    }
                }

                if (!find) 
                { 
                    nodeValues.Add(node.val);
                }
            }

            Traverse(node.next);
        }

        head = null;
        if (nodeValues.Count > 0)
        {
            head = new(nodeValues[0]);
            ListNode pointer = head;
            for (int i = 1; i < nodeValues.Count; i++)
            {
                pointer.next = new(nodeValues[i]);
                pointer = pointer.next;
            }
        }

        return head;
    }
}


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) 
    {
        this.val = val;
        this.next = next;
    }
}