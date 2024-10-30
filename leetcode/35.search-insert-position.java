/*
 * @lc app=leetcode id=35 lang=java
 *
 * [35] Search Insert Position
 *
 * https://leetcode.com/problems/search-insert-position/description/
 *
 * algorithms
 * Easy (44.70%)
 * Likes:    15397
 * Dislikes: 677
 * Total Accepted:    2.6M
 * Total Submissions: 5.8M
 * Testcase Example:  '[1,3,5,6]\n5'
 *
 * Given a sorted array of distinct integers and a target value, return the
 * index if the target is found. If not, return the index where it would be if
 * it were inserted in order.
 * 
 * You must write an algorithm with O(log n) runtime complexity.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,3,5,6], target = 5
 * Output: 2
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [1,3,5,6], target = 2
 * Output: 1
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: nums = [1,3,5,6], target = 7
 * Output: 4
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 10^4
 * -10^4 <= nums[i] <= 10^4
 * nums contains distinct values sorted in ascending order.
 * -10^4 <= target <= 10^4
 * 
 * 
 */

// @lc code=start
class Solution {
    public int searchInsert(int[] nums, int target) {
        if (nums.length == 0 || target < nums[0])
            return 0;
        int start = 0, end = nums.length - 1;
        while (start <= end) {
            int m = (start + end) / 2;
            if (nums[m] < target) {
                if (m < nums.length - 1 && target <= nums[m + 1]) {
                    return m + 1;
                }
                start = m + 1;
            } else if (nums[m] > target) {
                end = m - 1;
            } else
                return m;
        }
        return nums.length;
    }
}
// @lc code=end
