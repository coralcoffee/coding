/*
 * @lc app=leetcode id=163 lang=csharp
 *
 * [163] Missing Ranges
 *
 * https://leetcode.com/problems/missing-ranges/description/
 *
 * algorithms
 * Easy (32.84%)
 * Likes:    1122
 * Dislikes: 2991
 * Total Accepted:    263.5K
 * Total Submissions: 764.4K
 * Testcase Example:  '[0,1,3,50,75]\n0\n99'
 *
 * You are given an inclusive range [lower, upper] and a sorted unique integer
 * array nums, where all elements are within the inclusive range.
 * 
 * A number x is considered missing if x is in the range [lower, upper] and x
 * is not in nums.
 * 
 * Return the shortest sorted list of ranges that exactly covers all the
 * missing numbers. That is, no element of nums is included in any of the
 * ranges, and each missing number is covered by one of the ranges.
 * 
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [0,1,3,50,75], lower = 0, upper = 99
 * Output: [[2,2],[4,49],[51,74],[76,99]]
 * Explanation: The ranges are:
 * [2,2]
 * [4,49]
 * [51,74]
 * [76,99]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [-1], lower = -1, upper = -1
 * Output: []
 * Explanation: There are no missing ranges since there are no missing
 * numbers.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * -10^9 <= lower <= upper <= 10^9
 * 0 <= nums.length <= 100
 * lower <= nums[i] <= upper
 * All the values of nums are unique.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> FindMissingRanges(int[] nums, int lower, int upper)
    {
        if (nums.Length == 0) return [[lower, upper]];
        List<IList<int>> result = new List<IList<int>>();
        if (nums[0] != lower)
        {
            result.Add([lower, nums[0] - 1]);
        }
        for (int i = 1; i < nums.Length; i++)
        {
            int prev = nums[i - 1];
            int n = nums[i];
            if (n - prev > 1)
            {
                result.Add([prev + 1, n - 1]);
            }
        }
        if (nums[nums.Length - 1] != upper)
        {
            result.Add([nums[nums.Length - 1] + 1, upper]);
        }
        return result;
    }
}
// @lc code=end

