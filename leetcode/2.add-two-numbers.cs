/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 *
 * https://leetcode.com/problems/add-two-numbers/description/
 *
 * algorithms
 * Medium (41.52%)
 * Likes:    28995
 * Dislikes: 5622
 * Total Accepted:    4.1M
 * Total Submissions: 9.8M
 * Testcase Example:  '[2,4,3]\n[5,6,4]'
 *
 * You are given two non-empty linked lists representing two non-negative
 * integers. The digits are stored in reverse order, and each of their nodes
 * contains a single digit. Add the two numbers and return the sum as a linked
 * list.
 * 
 * You may assume the two numbers do not contain any leading zero, except the
 * number 0 itself.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: l1 = [2,4,3], l2 = [5,6,4]
 * Output: [7,0,8]
 * Explanation: 342 + 465 = 807.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: l1 = [0], l2 = [0]
 * Output: [0]
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
 * Output: [8,9,9,9,0,0,0,1]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of nodes in each linked list is in the range [1, 100].
 * 0 <= Node.val <= 9
 * It is guaranteed that the list represents a number that does not have
 * leading zeros.
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var result = new ListNode(0);
        ListNode ln1 = l1, ln2 = l2, current = result;
        int carry = 0, sum = 0;
        while (ln1 != null || ln2 != null)
        {
            int x = (ln1 != null) ? ln1.val : 0;
            int y = (ln2 != null) ? ln2.val : 0;

            sum = carry + x + y;
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
            if (ln1 != null) ln1 = ln1.next;
            if (ln2 != null) ln2 = ln2.next;
        }

        if (carry > 0)
        {
            current.next = new ListNode(1);
        }
        return result.next;
    }
}
// @lc code=end

