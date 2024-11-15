package samplej.practice.list;

import samplej.practice.utils.ListNode;

public class MyList {
    public static void main(String[] args) {
        int[] arr = {1,2,3,4,5};

        ListNode node = ListNode.toListNode(arr);

        while(node != null)
        {
            System.out.println(node.val);
            node = node.next;
        }
    }
}
