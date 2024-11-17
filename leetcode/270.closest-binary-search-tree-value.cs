/*
 * @lc app=leetcode id=270 lang=csharp
 *
 * [270] Closest Binary Search Tree Value
 *
 * https://leetcode.com/problems/closest-binary-search-tree-value/description/
 *
 * algorithms
 * Easy (52.98%)
 * Likes:    1837
 * Dislikes: 150
 * Total Accepted:    374.4K
 * Total Submissions: 738.3K
 * Testcase Example:  '[4,2,5,1,3]\n3.714286'
 *
 * Given the root of a binary search tree and a target value, return the value
 * in the BST that is closest to the target. If there are multiple answers,
 * print the smallest.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: root = [4,2,5,1,3], target = 3.714286
 * Output: 4
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: root = [1], target = 4.428571
 * Output: 1
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of nodes in the tree is in the range [1, 10^4].
 * 0 <= Node.val <= 10^9
 * -10^9 <= target <= 10^9
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
    public int ClosestValue(TreeNode root, double target)
    {
        if (root == null) return int.MaxValue;
        int left = ClosestValue(root.left, target);
        int right = ClosestValue(root.right, target);
        int min = root.val;
        if (Math.Abs(left - target) <= Math.Abs(min - target))
        {
            min = left;
        }
        if (Math.Abs(right - target) < Math.Abs(min - target))
        {
            min = right;
        }
        return min;
    }
}
// @lc code=end

