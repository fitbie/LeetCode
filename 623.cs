public class Solution {
    public TreeNode AddOneRow(TreeNode root, int val, int depth) 
    {
        if (depth == 1) { return new TreeNode(val, root); }

        Traverse(1, root);

        void Traverse(int curDepth, TreeNode? node)
        {
            if (node == null) { return; }

            if (++curDepth == depth)
            {
                node.left = new(val, node.left);
                node.right = new(val, null, node.right);
                return;
            }

            Traverse(curDepth, node.left);
            Traverse(curDepth, node.right);
        }

        return root;    
    }
}


public class TreeNode 
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val=0, TreeNode? left = null, TreeNode? right = null) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}