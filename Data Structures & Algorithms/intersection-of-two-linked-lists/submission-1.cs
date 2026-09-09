/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int lengthA = 0;
        ListNode cloneA = headA;
        while (cloneA != null) {
            lengthA++;
            cloneA = cloneA.next;
        }

        int lengthB = 0;
        ListNode cloneB = headB;
        while (cloneB != null) {
            lengthB++;
            cloneB = cloneB.next;
        }

        int diff = Math.Abs(lengthA - lengthB);
        if (lengthA > lengthB) {
            while (diff > 0) {
                headA = headA.next;
                diff--;
            }
        }
        else {
            while (diff > 0) {
                headB = headB.next;
                diff--;
            }
        }

        while (headA != headB) {
            headA = headA.next;
            headB = headB.next;
        }

        return headA;
    }
}