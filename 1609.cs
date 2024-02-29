Solution solution = new();
solution.IsEvenOddTree(new(1, new(10, new(3, new(12), new(8))), new(4, new(7, new(6)), new(9, null, new(2)))));

public class Solution 
{
    public bool IsEvenOddTree(TreeNode root) 
    {
        Queue<(TreeNode, int)> heap = new();
        List<TreeNode> currentRow = new();
        int index = 0;
        heap.Enqueue((root, index));

        while(heap.Count > 0)
        {
            while (heap.TryPeek(out var tuple) && tuple.Item2 == index)
            {
                currentRow.Add(heap.Dequeue().Item1);
            }
            
            bool even = index % 2 == 0;

            for (int i = 0; i < currentRow.Count; i++)
            {
                if (i + 1 < currentRow.Count)
                {
                    if (even && currentRow[i + 1].val <= currentRow[i].val) { return false; }
                    if (!even && currentRow[i + 1].val >= currentRow[i].val) { return false; }
                    
                }
                if (currentRow[i].val % 2 == 0 == even)
                {
                    return false;
                }

                if (currentRow[i].left != null) heap.Enqueue((currentRow[i].left, index + 1));
                if (currentRow[i].right != null) heap.Enqueue((currentRow[i].right, index + 1));
            }

            index++;
            currentRow.Clear();
            
        }

        return true;
    }
}


/*
public class Solution 
{
    public bool IsEvenOddTree(TreeNode root) 
    {
        Dictionary<int, List<int>> nodes = new();

        DFS(root, -1);

        void DFS(TreeNode node, int depth)
        {
            if (node == null) { return; }
            depth++;

            if (!nodes.TryGetValue(depth, out List<int>? value))
            {
                value = new();
                nodes.Add(depth, value);
            }

            value.Add(node.val);

            DFS(node.left, depth);
            DFS(node.right, depth);
        }

        foreach (var keyValue in nodes)
        {
            bool even = keyValue.Key % 2 == 0;

            for (int i = 0; i < keyValue.Value.Count; i++)
            {
                if (i + 1 < keyValue.Value.Count)
                {
                    if (even && keyValue.Value[i + 1] <= keyValue.Value[i]) { return false; }
                    if (!even && keyValue.Value[i + 1] >= keyValue.Value[i]) { return false; }
                    
                }
                if (keyValue.Value[i] % 2 == 0 == even)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
*/


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