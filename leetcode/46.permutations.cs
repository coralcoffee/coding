/*
 * @lc app=leetcode id=46 lang=csharp
 *
 * [46] Permutations
 *
 * https://leetcode.com/problems/permutations/description/
 *
 * algorithms
 * Medium (77.44%)
 * Likes:    19430
 * Dislikes: 342
 * Total Accepted:    2.3M
 * Total Submissions: 2.9M
 * Testcase Example:  '[1,2,3]'
 *
 * Given an array nums of distinct integers, return all the possible
 * permutations. You can return the answer in any order.
 * 
 * 
 * Example 1:
 * Input: nums = [1,2,3]
 * Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
 * Example 2:
 * Input: nums = [0,1]
 * Output: [[0,1],[1,0]]
 * Example 3:
 * Input: nums = [1]
 * Output: [[1]]
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 6
 * -10 <= nums[i] <= 10
 * All the integers of nums are unique.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        var permutations = new List<IList<int>>();
        Permute(nums, 0, nums.Length, permutations);
        return permutations;
    }

    void Permute(int[] array, int start, int end, List<IList<int>> result)
    {
        if (start == end)
        {
            result.Add(array.ToList());
            return;
        }

        for (int i = start; i < end; i++)
        {
            if (start != i)
            {
                Swap(array, start, i);
            }
            Permute(array, start + 1, end, result);
            if (start != i)
            {
                Swap(array, start, i);
            }
        }
    }
    private void Swap(int[] array, int i, int j)
    {
        if (i != j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
// @lc code=end

