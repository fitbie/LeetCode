public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) 
    {
        List<int> result = new();
        DFS(root);
        
        void DFS(TreeNode current)
        {
            if (current == null)
            {
                return;
            }
            
            DFS(current.left);
            DFS(current.right);

            result.Add(current.val);
        }

        return result;
    }
}


public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
 }