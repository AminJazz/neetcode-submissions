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
    public int PairSum(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        ListNode prev = null;

        //divide and reverse list
        while (fast != null && fast.next != null) {
            fast = fast.next.next;

            var temp = slow.next;
            slow.next = prev;

            prev = slow;
            slow = temp;
        }
        
        int max = int.MinValue;
        while (prev != null) {
            max = Math.Max(max, slow.val + prev.val);

            slow = slow.next;
            prev = prev.next;
        }

        return max;
    }
}