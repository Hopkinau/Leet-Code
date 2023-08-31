public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
           if (head == null) return null;
        ListNode slow = head, fast = head;
        while (fast != null) {
            if (fast.val != slow.val) {
                slow.next = fast;
                slow = slow.next;
            }
            fast = fast.next;
        }
        slow.next = null; // Disconnect from duplicate elements
        return head;
    }
    }
