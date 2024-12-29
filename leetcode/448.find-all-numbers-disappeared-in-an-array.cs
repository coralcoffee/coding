/*
 * @lc app=leetcode id=448 lang=csharp
 *
 * [448] Find All Numbers Disappeared in an Array
 *
 * https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
 *
 * algorithms
 * Easy (60.50%)
 * Likes:    9577
 * Dislikes: 506
 * Total Accepted:    983.5K
 * Total Submissions: 1.6M
 * Testcase Example:  '[4,3,2,7,8,2,3,1]'
 *
 * Given an array nums of n integers where nums[i] is in the range [1, n],
 * return an array of all the integers in the range [1, n] that do not appear
 * in nums.
 * 
 * 
 * Example 1:
 * Input: nums = [4,3,2,7,8,2,3,1]
 * Output: [5,6]
 * Example 2:
 * Input: nums = [1,1]
 * Output: [2]
 * 
 * 
 * Constraints:
 * 
 * 
 * n == nums.length
 * 1 <= n <= 10^5
 * 1 <= nums[i] <= n
 * 
 * 
 * 
 * Follow up: Could you do it without extra space and in O(n) runtime? You may
 * assume the returned list does not count as extra space.
 * 
 */

// @lc code=start
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var list = new List<int>();
        for (int i = 1; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
            {
                list.Add(i);
            }
        }
        return list;
    }
}
// @lc code=end

