using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
 
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode resultNode = new ListNode();
        ListNode calNode = resultNode;
        int extra = 0;

        while (l1 != null || l2 != null || extra != 0) {

            int value1 = l1 == null ? 0 : l1.val;
            int value2 = l2 == null ? 0 : l2.val;

            int sum = value1 + value2 + extra;

            extra = sum / 10;
            calNode.next = new ListNode(sum % 10);
            calNode = calNode.next;

            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;

        }
        return resultNode.next;
    }


    public static void Main(string[] args)
    {
        var p = new Program();
        var num1 = p.ListToListNode(new int[]{9,9,9,9,9,9,9});
        var num2 = p.ListToListNode(new int[]{9,9,9,9});
        var result = p.AddTwoNumbers(num1, num2);

    }
}
