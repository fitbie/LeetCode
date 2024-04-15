Solution solution = new();
solution.SumNumbers(new(1, new(2), new(3)));


public class Solution {
    public int SumNumbers(TreeNode root) 
    {
        int result = 0;

        Traverse(0, root);

        void Traverse(int number, TreeNode? node)
        {
            if (node == null) { return; }

            number = number * 10 + node.val;

            if (node.left == null && node.right == null)
            {
                result += number;
                return;
            }

            Traverse(number, node.left);
            Traverse(number, node.right);
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