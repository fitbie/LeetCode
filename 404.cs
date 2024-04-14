public class Solution {
    public int SumOfLeftLeaves(TreeNode root)
    {
        int result = 0;

        Traverse(root, false);

        void Traverse(TreeNode? current, bool left)
        {
            if (current == null) { return; }

            if (left && current.left == null && current.right == null)
            { result += current.val; }
            
            Traverse(current.left, true);
            Traverse(current.right, false);
        }

        return result;
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