/*
 * @lc app=leetcode id=18 lang=csharp
 *
 * [18] 4Sum
 *
 * https://leetcode.com/problems/4sum/description/
 *
 * algorithms
 * Medium (35.80%)
 * Likes:    10755
 * Dislikes: 1290
 * Total Accepted:    852.6K
 * Total Submissions: 2.4M
 * Testcase Example:  '[1,0,-1,0,-2,2]\n0'
 *
 * Given an array nums of n integers, return an array of all the unique
 * quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
 * 
 * 
 * 0 <= a, b, c, d < n
 * a, b, c, and d are distinct.
 * nums[a] + nums[b] + nums[c] + nums[d] == target
 * 
 * 
 * You may return the answer in any order.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,0,-1,0,-2,2], target = 0
 * Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [2,2,2,2,2], target = 8
 * Output: [[2,2,2,2]]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 200
 * -10^9 <= nums[i] <= 10^9
 * -10^9 <= target <= 10^9
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 3; i++)
        {
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                for (int k = j + 1; k < nums.Length - 1; k++)
                {
                    for (int l = k + 1; l < nums.Length; l++)
                    {
                        if (nums[i] + nums[j] + nums[k] + nums[l] == target
                        && i != j && i != k && i != l && j != k && j != l && k != l)
                        {
                            result.Add(new List<int>() { nums[i], nums[j], nums[k], nums[l] });
                        }
                    }
                }
            }
        }
        return result;
    }
}
// @lc code=end

