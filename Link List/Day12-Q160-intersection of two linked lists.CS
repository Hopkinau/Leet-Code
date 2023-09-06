//https://www.youtube.com/watch?v=0JHQ26NQcPk

public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int lenA = GetLength(headA);
        int lenB = GetLength(headB);
         while (lenA > lenB) {
            lenA--;
            headA = headA.next;
        }
        //This loop is effectively reducing the length of headA by 1 and moving the head to the next node. It continues until lenA becomes equal to lenB, meaning that headA has been adjusted to match the length of headB after accounting for the difference in lengths.
        
        while (lenB > lenA) {
            lenB--;
            headB = headB.next;
        }
        while(headA!=headB){
            headA=headA.next;
            headB=headB.next;
        }
        return headA;
        
    }
     private int GetLength(ListNode node) {
        int length = 0;
        while (node != null) {
            length++;
            node = node.next;
        }
        return length;
    }
}