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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int length = 0;
        var cur = head;
        while(cur != null){
            length++;
            cur = cur.next;
        }

        var removeIndex = length - n;
        if(removeIndex == 0)
            return head.next;

        cur = head;
        for(var i = 0; i < length - 1;i++){
            if(i + 1 == removeIndex)
            {
                cur.next = cur.next.next;
                break;
            }
            cur = cur.next;
        }

        return head;
    }
}
