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
    private Dictionary<int,int> inorderIndexMap;
    private int preorderIndex;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        inorderIndexMap = new();
        for(var i = 0; i < inorder.Length; i++){
            inorderIndexMap[inorder[i]] = i;
        }
        preorderIndex = 0;

        return Dfs(preorder, 0, inorder.Length - 1);
    }

    private TreeNode Dfs(int[] preorder, int inorderStart, int inorderEnd){
        if(inorderStart > inorderEnd) return null;

        var rootVal = preorder[preorderIndex];

        preorderIndex++;

        var root = new TreeNode(rootVal);

        int inorderRootIndex = inorderIndexMap[rootVal];

        root.left = Dfs(preorder, inorderStart, inorderRootIndex - 1);
        root.right = Dfs(preorder, inorderRootIndex + 1, inorderEnd);

        return root;
    }
}











