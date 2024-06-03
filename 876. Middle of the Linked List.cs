/*
876. Middle of the Linked List

Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.
*/

public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode current = head; int length = 1;
            while (current.next != null)
            {
                current = current.next;
                length++;
            }
            int i = 0;
            current = head;
            
            while (i < length / 2)
            {
                current = current.next;
                i++;
            }

            return current;
    }
}

