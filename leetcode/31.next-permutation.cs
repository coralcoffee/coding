/*
 * @lc app=leetcode id=31 lang=csharp
 *
 * [31] Next Permutation
 *
 * https://leetcode.com/problems/next-permutation/description/
 *
 * algorithms
 * Medium (38.81%)
 * Likes:    17569
 * Dislikes: 4474
 * Total Accepted:    1.2M
 * Total Submissions: 3.1M
 * Testcase Example:  '[1,2,3]'
 *
 * A permutation of an array of integers is an arrangement of its members into
 * a sequence or linear order.
 * 
 * 
 * For example, for arr = [1,2,3], the following are all the permutations of
 * arr: [1,2,3], [1,3,2], [2, 1, 3], [2, 3, 1], [3,1,2], [3,2,1].
 * 
 * 
 * The next permutation of an array of integers is the next lexicographically
 * greater permutation of its integer. More formally, if all the permutations
 * of the array are sorted in one container according to their lexicographical
 * order, then the next permutation of that array is the permutation that
 * follows it in the sorted container. If such arrangement is not possible, the
 * array must be rearranged as the lowest possible order (i.e., sorted in
 * ascending order).
 * 
 * 
 * For example, the next permutation of arr = [1,2,3] is [1,3,2].
 * Similarly, the next permutation of arr = [2,3,1] is [3,1,2].
 * While the next permutation of arr = [3,2,1] is [1,2,3] because [3,2,1] does
 * not have a lexicographical larger rearrangement.
 * 
 * 
 * Given an array of integers nums, find the next permutation of nums.
 * 
 * The replacement must be in place and use only constant extra memory.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,2,3]
 * Output: [1,3,2]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [3,2,1]
 * Output: [1,2,3]
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: nums = [1,1,5]
 * Output: [1,5,1]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 100
 * 0 <= nums[i] <= 100
 * 
 * 
 */

// @lc code=start
public class Solution
{
    private int[] _nums;
    public void NextPermutation(int[] nums)
    {
        if (nums == null || nums.Length < 2) return;
        _nums = nums;
        int i = nums.Length - 2;

        while (i >= 0 && nums[i] >= nums[i + 1])
        {
            i--;
        }

        if (i >= 0)
        {
            int j = nums.Length - 1;
            while (nums[j] <= nums[i])
            {
                j--;
            }
            Swap(i, j);
        }

        Reverse(i + 1, nums.Length - 1);
    }

    void Swap(int i, int j)
    {
        _nums[i] = _nums[i] ^ _nums[j];
        _nums[j] = _nums[i] ^ _nums[j];
        _nums[i] = _nums[i] ^ _nums[j];
    }

    void Reverse(int start, int end)
    {
        while (start < end)
        {
            Swap(start, end);
            start++;
            end--;
        }
    }
}
// @lc code=end

