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
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        var dummy = new ListNode(-1);
        var node = dummy;
        var l1 = list1;
        var l2 = list2;
        while(l1 != null && l2 != null) {
            if(l1.val < l2.val){
                node.next = l1;
                l1 = l1.next;
            }
            else{
                node.next = l2;
                l2 = l2.next;
            }
            node = node.next;
        }
         if(l1 == null)
                node.next = l2;
            else 
                node.next = l1;
        return dummy.next;
    }
}