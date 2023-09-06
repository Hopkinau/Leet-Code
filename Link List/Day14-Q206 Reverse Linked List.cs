public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode current = head;
        
        while (current != null) {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        
        return prev; // 'prev' will be the new head of the reversed list
    }
}