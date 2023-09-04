//This is Questions relate to Q206,
//https://www.youtube.com/watch?v=WyI5dXMHW5c
public class Solution {
    public bool IsPalindrome(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while(fast!=null && fast.next!=null){
            slow = slow.next;
            fast = fast.next.next;
        }

        slow = Reverse(slow);
        fast= head;
        while(slow!=null){
            if(slow.val != fast.val){
                return false;
            }
            slow=slow.next;
            fast=fast.next;
        }
        return true;



   
        
    }
        private ListNode Reverse(ListNode head)
    {
        ListNode pre = null, cur = head;
        while (cur != null)
        {
            ListNode next = cur.next;
            cur.next = pre;
            pre = cur;
            cur = next;
        }
        return pre;
    }
}