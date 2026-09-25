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
    private List<int> result = new List<int>();
    public List<int> PostorderTraversal(TreeNode root) {
        if (root == null) return new List<int>();

        PostorderTraversal(root.left);
        PostorderTraversal(root.right);
        result.Add(root.val);

        return result;
    }
}