
namespace LitCode938
{

public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left = null!, TreeNode right= null!) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}


public class Solution {
    public int RangeSumBST(TreeNode root, int low, int high) 
    {
        int result = 0;
        TreeNode currentNode = root;
        FindAll(root);

        void FindAll(TreeNode node)
        {
            if (node.val >= low && node.val <= high) { result += node.val; }
            if (node.left != null) { FindAll(node.left); }
            if (node.right != null) { FindAll(node.right); }
        }

        return result;
    }
}

}