/*
 * @lc app=leetcode id=414 lang=csharp
 *
 * [414] Third Maximum Number
 *
 * https://leetcode.com/problems/third-maximum-number/description/
 *
 * algorithms
 * Easy (34.05%)
 * Likes:    3147
 * Dislikes: 3269
 * Total Accepted:    615.6K
 * Total Submissions: 1.7M
 * Testcase Example:  '[3,2,1]'
 *
 * Given an integer array nums, return the third distinct maximum number in
 * this array. If the third maximum does not exist, return the maximum
 * number.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [3,2,1]
 * Output: 1
 * Explanation:
 * The first distinct maximum is 3.
 * The second distinct maximum is 2.
 * The third distinct maximum is 1.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [1,2]
 * Output: 2
 * Explanation:
 * The first distinct maximum is 2.
 * The second distinct maximum is 1.
 * The third distinct maximum does not exist, so the maximum (2) is returned
 * instead.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: nums = [2,2,3,1]
 * Output: 1
 * Explanation:
 * The first distinct maximum is 3.
 * The second distinct maximum is 2 (both 2's are counted together since they
 * have the same value).
 * The third distinct maximum is 1.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 10^4
 * -2^31 <= nums[i] <= 2^31 - 1
 * 
 * 
 * 
 * Follow up: Can you find an O(n) solution?
 */

// @lc code=start
public class Solution
{
    public int ThirdMax(int[] nums)
    {
        int count = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            int d = nums[i];
            int j = i > 2 ? 2 : i - 1;
            bool exists = false;
            for (int k = 0; k <=j ; k++)
            {
                if (nums[k] == d)
                {
                    nums[i] = int.MinValue;
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                while (j >= 0 && d > nums[j])
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                if (j < 3) count++;
                nums[j + 1] = d;
            }
        }

        if (count >= 2)
            return nums[2];
        else
            return nums[0];
    }
}
// @lc code=end

