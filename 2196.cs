Solution solution = new();
solution.CreateBinaryTree([[20,15,1],[20,17,0],[50,20,1],[50,80,0],[80,19,1]]);


public class Solution {
    public TreeNode CreateBinaryTree(int[][] descriptions) 
    {
        Dictionary<int, TreeNode> nodesCached = new Dictionary<int, TreeNode>();
        int parentCounter = 0;
        List<TreeNode> parents = new();
        List<TreeNode> children = new();

        for (int i = 0; i < descriptions.Length; i++)
        {
            int parentVal = descriptions[i][0];
            int childVal = descriptions[i][1];
            TreeNode parent;
            TreeNode child;

            if (!nodesCached.TryGetValue(parentVal, out TreeNode? value))
            {
                parent = new TreeNode(parentVal);
                nodesCached.Add(parentVal, parent);
                parents.Add(parent);
            }
            else
            {
                parent = value;
            }

            if (!nodesCached.TryGetValue(childVal, out value))
            {
                child = new TreeNode(childVal);
                nodesCached.Add(childVal, child);
            }
            else
            {
                child = value;
            }

            children.Add(child);

            if (descriptions[i][2] == 1)
            {
                parent.left = child;
            }
            else
            {
                parent.right = child;
            }
        }

        return parents.Except(children).First();
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