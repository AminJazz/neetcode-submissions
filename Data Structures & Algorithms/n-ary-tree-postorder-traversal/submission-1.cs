/*
// Definition for a Node.
public class Node {
    public int val;
    public List<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public List<int> Postorder(Node root) {
        if (root == null) return new List<int>();

        var result = new List<int>();
        void Order(List<Node> root) {
            if (root == null || root.Count == 0) return;

            foreach(var child in root) {
                Order(child.children);
                result.Add(child.val);
            }
        }

        Order(root.children);
        result.Add(root.val);

        return result;
    }
}