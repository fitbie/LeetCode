
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}


public class Solution {
    public Node CopyRandomList(Node head)
    {
        if (head == null) { return null; }

        Dictionary<Node, Node> copys = new();
        Node result = GetCopy(head);
        Node current = result;

        DeepCopy(head);

        void DeepCopy(Node node)
        {
            if (node == null) { return; }

            if (node.next != null) 
            {
                current.next = GetCopy(node.next);
            }
            if (node.random != null) 
            {
                current.random = GetCopy(node.random);
            }

            current = current.next;
            DeepCopy(node.next);
        }


        Node GetCopy(Node node)
        {
            if (copys.ContainsKey(node))
            {
                return copys[node];
            } 
            else
            {
                Node copy = new(node.val);
                copys.Add(node, copy);
                return copy;
            }
        }


        return result;
    }
}