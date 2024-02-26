Solution solution = new();
solution.IsSameTree(new(1, new(2), new(3)), new(1, new(2), new(3)));

 
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) 
    {
        HashSet<TreeNode> visited = new HashSet<TreeNode>();

        Queue<TreeNode> unVisited = new Queue<TreeNode>();
        unVisited.Enqueue(p);
        unVisited.Enqueue(q);

        while (unVisited.Count > 0)
        {
            var f = unVisited.Dequeue();
            var s = unVisited.Dequeue();

            if (f?.val != s?.val) { return false; }

            if (f != null)
            {
                visited.Add(f);
                if (!visited.Contains(f.left)) { unVisited.Enqueue(f.left); }
            }
            if (s != null)
            {
                visited.Add(s);
                if (!visited.Contains(s.left)) { unVisited.Enqueue(s.left); }
            }
            if (f != null)
            {
                if (!visited.Contains(f.right)) { unVisited.Enqueue(f.right); }
            }
            if (s != null)
            {
                if (!visited.Contains(s.right)) { unVisited.Enqueue(s.right); }
            }
        }

        return true;
    }
}



public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}