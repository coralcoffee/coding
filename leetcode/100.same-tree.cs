/*
 * @lc app=leetcode id=100 lang=csharp
 *
 * [100] Same Tree
 *
 * https://leetcode.com/problems/same-tree/description/
 *
 * algorithms
 * Easy (59.98%)
 * Likes:    11792
 * Dislikes: 251
 * Total Accepted:    2.5M
 * Total Submissions: 3.9M
 * Testcase Example:  '[1,2,3]\n[1,2,3]'
 *
 * Given the roots of two binary trees p and q, write a function to check if
 * they are the same or not.
 * 
 * Two binary trees are considered the same if they are structurally identical,
 * and the nodes have the same value.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: p = [1,2,3], q = [1,2,3]
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: p = [1,2], q = [1,null,2]
 * Output: false
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: p = [1,2,1], q = [1,1,2]
 * Output: false
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of nodes in both trees is in the range [0, 100].
 * -10^4 <= Node.val <= 10^4
 * 
 * 
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        return IsSame(p, q);
    }

    public bool IsSame(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        else if (p == null || q == null)
            return false;
        return p.val == q.val
            && IsSame(p.left, q.left) 
            && IsSame(p.right, q.right);
    }
}
// @lc code=end

