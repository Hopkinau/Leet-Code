// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var dummy = new ListNode(0, head);
        var left = dummy;
        var right = head;
        
        while(n > 0) {
            right = right.next;
            n--;
        }
        
        while(right != null) {
            left = left.next;
            right = right.next;
        }
        
        // delete
        left.next = left.next.next;
        return dummy.next;
    }
}