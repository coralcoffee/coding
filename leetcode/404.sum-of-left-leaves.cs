/*
 * @lc app=leetcode id=404 lang=csharp
 *
 * [404] Sum of Left Leaves
 *
 * https://leetcode.com/problems/sum-of-left-leaves/description/
 *
 * algorithms
 * Easy (57.35%)
 * Likes:    5532
 * Dislikes: 312
 * Total Accepted:    665.5K
 * Total Submissions: 1.1M
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given the root of a binary tree, return the sum of all left leaves.
 * 
 * A leaf is a node with no children. A left leaf is a leaf that is the left
 * child of another node.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: root = [3,9,20,null,null,15,7]
 * Output: 24
 * Explanation: There are two left leaves in the binary tree, with values 9 and
 * 15 respectively.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: root = [1]
 * Output: 0
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of nodes in the tree is in the range [1, 1000].
 * -1000 <= Node.val <= 1000
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
    public int SumOfLeftLeaves(TreeNode root)
    {
        if (root == null) return 0;

        int result = 0;

        if (root.left != null && root.left.left == null && root.left.right == null)
        {
            result = root.left.val;
        }
        if (root.left != null)
            result += SumOfLeftLeaves(root.left);
        if (root.right != null)
            result += SumOfLeftLeaves(root.right);
        return result;
    }
}
// @lc code=end

