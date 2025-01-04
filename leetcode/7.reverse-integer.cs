/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 *
 * https://leetcode.com/problems/reverse-integer/description/
 *
 * algorithms
 * Medium (27.97%)
 * Likes:    12108
 * Dislikes: 13115
 * Total Accepted:    2.9M
 * Total Submissions: 10.3M
 * Testcase Example:  '123'
 *
 * Given a signed 32-bit integer x, return x with its digits reversed. If
 * reversing x causes the value to go outside the signed 32-bit integer range
 * [-2^31, 2^31 - 1], then return 0.
 * 
 * Assume the environment does not allow you to store 64-bit integers (signed
 * or unsigned).
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: x = 123
 * Output: 321
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: x = -123
 * Output: -321
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: x = 120
 * Output: 21
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * -2^31 <= x <= 2^31 - 1
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int Reverse(int x)
    {
        int result = 0;
        int max = Int32.MaxValue / 10;
        int min = Int32.MinValue / 10;
        while (x != 0)
        {
            int pop = x % 10;
            x /= 10;
            if (result > max || (result == max && pop > 7)) return 0;
            if (result < min || (result == min && pop < -8)) return 0;
            result = result * 10 + pop;
        }
        return result;
    }
}
// @lc code=end

