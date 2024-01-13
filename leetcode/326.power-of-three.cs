/*
 * @lc app=leetcode id=326 lang=csharp
 *
 * [326] Power of Three
 *
 * https://leetcode.com/problems/power-of-three/description/
 *
 * algorithms
 * Easy (46.04%)
 * Likes:    2980
 * Dislikes: 272
 * Total Accepted:    778.5K
 * Total Submissions: 1.7M
 * Testcase Example:  '27'
 *
 * Given an integer n, return true if it is a power of three. Otherwise, return
 * false.
 * 
 * An integer n is a power of three, if there exists an integer x such that n
 * == 3^x.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: n = 27
 * Output: true
 * Explanation: 27 = 3^3
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: n = 0
 * Output: false
 * Explanation: There is no x where 3^x = 0.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: n = -1
 * Output: false
 * Explanation: There is no x where 3^x = (-1).
 * 
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
    public bool IsPowerOfThree(int n)
    {
        if (n < 1) return false;
        while (n % 3 == 0)
        {
            n = n / 3;
            if (n == 1) return true;
        }
        return n == 1;
    }
}
// @lc code=end

