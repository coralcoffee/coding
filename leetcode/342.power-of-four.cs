/*
 * @lc app=leetcode id=342 lang=csharp
 *
 * [342] Power of Four
 *
 * https://leetcode.com/problems/power-of-four/description/
 *
 * algorithms
 * Easy (47.57%)
 * Likes:    3970
 * Dislikes: 400
 * Total Accepted:    731.4K
 * Total Submissions: 1.5M
 * Testcase Example:  '16'
 *
 * Given an integer n, return true if it is a power of four. Otherwise, return
 * false.
 * 
 * An integer n is a power of four, if there exists an integer x such that n ==
 * 4^x.
 * 
 * 
 * Example 1:
 * Input: n = 16
 * Output: true
 * Example 2:
 * Input: n = 5
 * Output: false
 * Example 3:
 * Input: n = 1
 * Output: true
 * 
 * 
 * Constraints:
 * 
 * 
 * -2^31 <= n <= 2^31 - 1
 * 
 * 
 * 
 * Follow up: Could you solve it without loops/recursion?
 */

// @lc code=start
public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        if (n == 1) return true;
        if (n % 4 != 0) return false;

        for (int i = 0; i < 16 && n > 0; i++)
        {
            if (n % 4 != 0) return false;
            if (n == 4) return true;
            n = n >> 2;
        }
        return false;
    }
}
// @lc code=end

