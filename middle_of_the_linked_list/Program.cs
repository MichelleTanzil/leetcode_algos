using System;

namespace middle_of_the_linked_list
{
  class Program
  {
    /**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int x) { val = x; }
* }
*/
    public ListNode MiddleNode(ListNode head)
    {
      if (head == null) return null;
      ListNode slow = head;
      ListNode fast = head.next;

      while (fast != null && fast.next != null)
      {
        fast = fast.next.next;
        slow = slow.next;
      }
      return slow;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
