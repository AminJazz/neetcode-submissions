/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int size = 0;
        ListNode countNode = head;
        while (countNode != null) {
            size++;
            countNode = countNode.next;
        }

        if (size - n == 0) return head.next;

        int index = size - n;
        ListNode node = head;
        while (index - 1 > 0) {
            node = node.next;
            index--;
        }
        node.next = node.next.next;
        return head;
    }
}
