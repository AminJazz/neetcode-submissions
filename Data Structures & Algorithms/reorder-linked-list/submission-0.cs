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
    public void ReorderList(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        ListNode first = slow;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode second = ReverseLinkedList(slow);
        ListNode result = new ListNode(0);
        ListNode r = result;
        while (first.next != null) {
            result.next = first;
            result = result.next;
            first = first.next;
            result.next = second;
            second = second.next;
            result = result.next;
        }

        while (second != null) {
            result.next = second;
            second = second.next;
        }

        head = r.next;
    }

    public ListNode ReverseLinkedList(ListNode list) {
        ListNode cur = list;
        ListNode prev = null;

        while (cur != null) {
            ListNode next = cur.next;
            cur.next = prev;
            prev = cur;
            cur = next;
        }

        return prev;
    }
}
