
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


public class Solution 
{
    public int FindBottomLeftValue(TreeNode root)
    {   
        int result = root.val;
        int maxHeight = -1;
        
        DFS(root, maxHeight);

        void DFS(TreeNode node, int order)
        {
            if (node == null) { return; }
            order++;

            if (order > maxHeight) { maxHeight = order; result = node.val; }

            DFS(node.left, order);
            DFS(node.right, order);
        }

        return result;
    }

}


// public class Solution {
//     public int FindBottomLeftValue(TreeNode root) 
//     {
//         (int value, int order) result = (root.val, 0);

//         Queue<(TreeNode node, int order)> unVisited = new();
//         unVisited.Enqueue((root, 0));

//         while(unVisited.Count > 0)
//         {
//             (TreeNode current, int order) = unVisited.Dequeue();

//             if (current.left != null)
//             {
//                 if (result.order < order + 1) { result = (current.left.val, order + 1); }
//                 unVisited.Enqueue((current.left, order + 1));
//             }
//             if (current.right != null)
//             {
//                 if (current.left == null && result.order < order + 1) { result = (current.right.val, order + 1); }
//                 unVisited.Enqueue((current.right, order + 1));
//             }
//         }
        

//         return result.value;    
//     }
// }