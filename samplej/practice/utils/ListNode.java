package samplej.practice.utils;

public class ListNode {
    public int val;
    public ListNode next;

    public ListNode(int val) {
        this.val = val;
    }

    public static ListNode toListNode(int[] arr)
    {
        var dum = new ListNode(0);
        var head = dum;
        for(int num: arr)
        {   
            head.next = new ListNode(num);
            head = head.next;
        }
        return dum.next;
    }
}