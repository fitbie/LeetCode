public class Solution {
    public bool EvaluateTree(TreeNode root) 
    {
        return root.val switch
            {
                0 or 1 => root.val == 1,
                2 => EvaluateTree(root.left) || EvaluateTree(root.right),
                3 => EvaluateTree(root.left) && EvaluateTree(root.right),
                _ => throw new Exception("Unknown value")
            };
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