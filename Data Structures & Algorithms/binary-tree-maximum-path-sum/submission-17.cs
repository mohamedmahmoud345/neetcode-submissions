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
    public int MaxPathSum(TreeNode root) {
        int res = root.val;
        DFS(root,ref res);
        return res;
    }
    private int DFS(TreeNode root, ref int res){
        if(root is null) return 0;

        var leftMax = Math.Max(DFS(root.left, ref res), 0);
        var rightMax = Math.Max(DFS(root.right, ref res), 0);

        res = Math.Max(res, root.val + leftMax + rightMax);

        return root.val + Math.Max(leftMax , rightMax);
    }
}
