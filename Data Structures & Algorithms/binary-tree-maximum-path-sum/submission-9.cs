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
    private int res = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        DFS(root);
        return res;
    }

    private int GetMax(TreeNode root){
        if(root is null) return 0;

        var left = GetMax(root.left);
        var right = GetMax(root.right);
        int path = root.val + Math.Max(left , right);
        return Math.Max(0, path);
    }

    private void DFS(TreeNode root){
        if(root is null) return;

        var left = GetMax(root.left);
        var right = GetMax(root.right);
        res = Math.Max(res , root.val + left + right);
        DFS(root.left);
        DFS(root.right);
    }
}
