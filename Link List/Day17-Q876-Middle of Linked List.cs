//https://www.youtube.com/watch?v=IPaMfcxQtP0
//Two points, slow and fast, very easy problems
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode slow =head;
        ListNode fast = head;
        while(fast!=null && fast.next!=null){
            slow=slow.next;
            fast=fast.next.next;
        }
        return slow;
        
    }
}