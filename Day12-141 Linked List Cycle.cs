//https://www.youtube.com/watch?v=wDgDAOVqhhA&t=336s
//This Question is classic of Double linked list, fast and slow pointer
//Its hard to understand the questions, however when you watch the youtube and 
//understand the logical behind it, its going to be very easy.

public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode fast = head,slow = head;
        while(fast.next != null && fast !=null){
            slow = slow.next;
            fast = fast.next.next;
            if(slow =fast){
                return true;
            }
        }
        return false;
    }}