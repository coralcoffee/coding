/*
 * @lc app=leetcode id=23 lang=csharp
 *
 * [23] Merge k Sorted Lists
 *
 * https://leetcode.com/problems/merge-k-sorted-lists/description/
 *
 * algorithms
 * Hard (51.26%)
 * Likes:    18811
 * Dislikes: 682
 * Total Accepted:    1.8M
 * Total Submissions: 3.6M
 * Testcase Example:  '[[1,4,5],[1,3,4],[2,6]]'
 *
 * You are given an array of k linked-lists lists, each linked-list is sorted
 * in ascending order.
 * 
 * Merge all the linked-lists into one sorted linked-list and return it.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: lists = [[1,4,5],[1,3,4],[2,6]]
 * Output: [1,1,2,3,4,4,5,6]
 * Explanation: The linked-lists are:
 * [
 * ⁠ 1->4->5,
 * ⁠ 1->3->4,
 * ⁠ 2->6
 * ]
 * merging them into one sorted list:
 * 1->1->2->3->4->4->5->6
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: lists = []
 * Output: []
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: lists = [[]]
 * Output: []
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * k == lists.length
 * 0 <= k <= 10^4
 * 0 <= lists[i].length <= 500
 * -10^4 <= lists[i][j] <= 10^4
 * lists[i] is sorted in ascending order.
 * The sum of lists[i].length will not exceed 10^4.
 * 
 * 
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        ListNode head = new ListNode(0);
        ListNode current = head;
        while (true)
        {
            int index = -1;
            for (int i = 0; i < lists.Length; i++)
            {
                if (index < 0 && lists[i] != null)
                {
                    index = i;
                    continue;
                }
                if (lists[i] != null && lists[index].val > lists[i].val)
                    index = i;
            }
            if (index < 0) break;
            current.next = lists[index];
            current = current.next;
            lists[index] = lists[index].next;
        }

        return head.next;
    }
}
// @lc code=end

