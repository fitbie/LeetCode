public class Solution {
    public IList<int> Postorder(Node root) 
    {
        IList<int> result = new List<int>();
        Traverse(root);

        void Traverse(Node current)
        {
            if (current == null)
            {
                return;
            }

            for (int i = 0; i < current.children.Count; i++)
            {
                Traverse(current.children[i]);
            }

            result.Add(current.val);
        }

        return result;
    }
}


public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}