Solution solution = new();
// solution.DiameterOfBinaryTree(new(1, new(2, new(4), new(5)), new (3)));
solution.DiameterOfBinaryTree(new(1, null, new(2, new(3, new(9), new(4)), new(6, new(5), new(11)))));


public class Solution {
    public int DiameterOfBinaryTree(TreeNode root) 
    {
        int result = 0;

        GetHeight(root);

        int GetHeight(TreeNode node)
        {
            if (node == null) { return 0; }

            int lHeight = 0;
            int rHeight = 0;

            if (node.left != null)
            {
                lHeight = 1 + GetHeight(node.left);
            }

            if (node.right != null)
            {
                rHeight = 1 + GetHeight(node.right);
            }

            result = Math.Max(lHeight + rHeight, result);

            int maxBranch = Math.Max(lHeight, rHeight);

            return maxBranch;
        }

        return result;

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
 