
public class Solution 
{
    public TreeNode RemoveLeafNodes(TreeNode root, int target) 
    {
        root = Traverse(root);
        return root;

        TreeNode? Traverse(TreeNode? node)
        {
            if (node == null) { return null; }
            
            node.left = Traverse(node.left);
            node.right = Traverse(node.right);
            return node.left == null && node.right == null && node.val == target ? null : node;
        }
        
    }
}


public class TreeNode {
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}