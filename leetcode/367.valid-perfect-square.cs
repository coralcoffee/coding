/*
 * @lc app=leetcode id=367 lang=csharp
 *
 * [367] Valid Perfect Square
 *
 * https://leetcode.com/problems/valid-perfect-square/description/
 *
 * algorithms
 * Easy (43.44%)
 * Likes:    4329
 * Dislikes: 313
 * Total Accepted:    689.3K
 * Total Submissions: 1.6M
 * Testcase Example:  '16'
 *
 * Given a positive integer num, return true if num is a perfect square or
 * false otherwise.
 * 
 * A perfect square is an integer that is the square of an integer. In other
 * words, it is the product of some integer with itself.
 * 
 * You must not use any built-in library function, such as sqrt.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: num = 16
 * Output: true
 * Explanation: We return true because 4 * 4 = 16 and 4 is an integer.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: num = 14
 * Output: false
 * Explanation: We return false because 3.742 * 3.742 = 14 and 3.742 is not an
 * integer.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= num <= 2^31 - 1
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        if (num == 1) return true;
        int low = 1, high = 46340;
        if (high > num) high = num;
        while (low <= high)
        {
            int mid = (high + low) / 2;
            int sqr = mid * mid;
            if (sqr == num)
                return true;
            else if (sqr < num)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return false;
    }
}
// @lc code=end

