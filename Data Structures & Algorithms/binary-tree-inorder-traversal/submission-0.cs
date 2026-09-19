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
    public List<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        InOrderTraversal(root, result);
        return result;
    }

    public void InOrderTraversal(TreeNode root, List<int> list) {
        if (root == null) return;

        //traverse all left
        InOrderTraversal(root.left, list);
        //print parent node
        list.Add(root.val);

        //traverse all right
        InOrderTraversal(root.right, list);
    }
}