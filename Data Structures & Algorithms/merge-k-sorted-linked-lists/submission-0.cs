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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0) return null;

        for(var i = 1; i < lists.Length; i++) {
            lists[i] = MergeTwoLists(lists[i], lists[i - 1]);
        }
        return lists[lists.Length - 1];
    }
    private ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var dummy = new ListNode(0);
        var cur = dummy;
        while(l1 != null && l2 != null) {
            if(l1.val <= l2.val) {
                cur.next = l1;;
                l1 = l1.next;
            }
            else {
                cur.next = l2;
                l2 = l2.next;
            }
            cur = cur.next;
        }
        if(l1 != null)
            cur.next = l1;
        else 
            cur.next = l2;

        return dummy.next;
    }
}
