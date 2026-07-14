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
    public List<List<int>> LevelOrder(TreeNode root) {
        // here is the using of breadth first search 

        var q = new Queue<TreeNode>();
        var res = new List<List<int>>();
        q.Enqueue(root);

        while(q.Count > 0) {
            var list = new List<int>();
            for(var i = q.Count; i > 0; i--){
                var node = q.Dequeue();
                if(node != null) {
                    list.Add(node.val);
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }

            if(list.Count > 0)
                res.Add(list);
        }

        return res;
    }
}
