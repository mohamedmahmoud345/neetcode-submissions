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
    public int KthSmallest(TreeNode root, int k) {
        var list = new List<int>();

        Dfs(root, list);
        return list[k - 1];
    }

    private void Dfs(TreeNode node, List<int> arr){
        if(node is null) return;
        Dfs(node.left, arr);
        arr.Add(node.val);
        Dfs(node.right, arr);
    } 
}
