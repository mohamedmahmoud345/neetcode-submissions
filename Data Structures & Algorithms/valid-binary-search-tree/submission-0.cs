/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsValidBST(TreeNode root) {
        return BFS(root, long.MinValue, long.MaxValue);
    }

    private bool BFS(TreeNode root, long min, long max){
        if(root is null) return true;

         if (!(min < root.val && root.val < max)) {
            return false;
        }
            
        return BFS(root.left, min ,root.val) && BFS(root.right, root.val, max);
    }
}
