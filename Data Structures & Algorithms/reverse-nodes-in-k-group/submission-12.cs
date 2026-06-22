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
    public ListNode ReverseKGroup(ListNode head, int k) {
        var dummy = new ListNode(0, head);
        var groupPrev = dummy;

        while(true) {
            var kth = GetKth(groupPrev, k);
            if(kth == null)
                break;

            var groupNext = kth.next;
            var prev = groupNext;
            var curr = groupPrev.next;

            while(curr != groupNext) {
                var temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            var tempNode = groupPrev.next;
            groupPrev.next = kth;
            groupPrev = tempNode;
        }
        return dummy.next;
    }

    private ListNode GetKth(ListNode cur, int k) {
        while(cur != null && k > 0) {
            cur = cur.next;
            k--;
        }
        return cur;
    }
}
