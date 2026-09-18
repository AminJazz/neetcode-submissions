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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode merge = new ListNode(0);
        ListNode result = merge;

        while (list1 != null && list2 != null) {
            if (list1.val <= list2.val) {
                merge.next = new ListNode(list1.val);
                merge = merge.next;
                list1 = list1.next;
            }
            else {
                merge.next = new ListNode(list2.val);
                merge = merge.next;
                list2 = list2.next;
            }
        }

        while (list1 != null) {
            merge.next = new ListNode(list1.val);
            merge = merge.next;
            list1 = list1.next;
        }

        while (list2 != null) {
            merge.next = new ListNode(list2.val);
            merge = merge.next;
            list2 = list2.next;
        }

        return result.next;
    }
}