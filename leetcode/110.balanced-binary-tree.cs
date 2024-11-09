/*
 * @lc app=leetcode id=110 lang=csharp
 *
 * [110] Balanced Binary Tree
 *
 * https://leetcode.com/problems/balanced-binary-tree/description/
 *
 * algorithms
 * Easy (50.76%)
 * Likes:    10970
 * Dislikes: 726
 * Total Accepted:    1.7M
 * Total Submissions: 3.2M
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given a binary tree, determine if it is height-balanced.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: root = [3,9,20,null,null,15,7]
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: root = [1,2,2,3,3,null,null,4,4]
 * Output: false
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: root = []
 * Output: true
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of nodes in the tree is in the range [0, 5000].
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
    public bool IsBalanced(TreeNode root)
    {
        return GetHeight(root) != -1;
    }

    private int GetHeight(TreeNode node)
    {
        if (node == null) return 0;

        int leftHeight = GetHeight(node.left);
        if (leftHeight == -1) return -1;

        int rightHeight = GetHeight(node.right);
        if (rightHeight == -1) return -1;

        if (Math.Abs(leftHeight - rightHeight) > 1)
            return -1;

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
public class Solution1
{
    public bool IsBalanced(TreeNode root)
    {
        if (root == null) return true;

        return IsBalanced(root.left)
            && IsBalanced(root.right)
            && Math.Abs(GetHeight(root.left) - GetHeight(root.right)) <= 1;
    }

    private int GetHeight(TreeNode root)
    {
        if (root == null) return 0;

        return Math.Max(GetHeight(root.left), GetHeight(root.right)) + 1;
    }
}
// @lc code=end

