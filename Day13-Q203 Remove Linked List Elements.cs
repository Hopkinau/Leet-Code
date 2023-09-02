//https://www.youtube.com/watch?v=uIcClozwlxc

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
    public ListNode RemoveElements(ListNode head, int val) {
        // Create a dummy node to simplify edge cases.
        ListNode dummy = new ListNode(-1);
        dummy.next = head;

        // Initialize a current node to traverse the list.
        ListNode cur = dummy;

        while (cur != null) {
            // Check if the next node's value matches the target value.
            if (cur.next != null && cur.next.val == val) {
                // Skip the next node by updating the pointer.
                cur.next = cur.next.next;
            } else {
                // Move to the next node.
                cur = cur.next;
            }
        }

        // Return the modified list (excluding the dummy node).
        return dummy.next;
    }
}
