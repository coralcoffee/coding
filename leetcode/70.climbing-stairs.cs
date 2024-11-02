/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 *
 * https://leetcode.com/problems/climbing-stairs/description/
 *
 * algorithms
 * Easy (52.24%)
 * Likes:    22371
 * Dislikes: 889
 * Total Accepted:    3.7M
 * Total Submissions: 7M
 * Testcase Example:  '2'
 *
 * You are climbing a staircase. It takes n steps to reach the top.
 * 
 * Each time you can either climb 1 or 2 steps. In how many distinct ways can
 * you climb to the top?
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: n = 2
 * Output: 2
 * Explanation: There are two ways to climb to the top.
 * 1. 1 step + 1 step
 * 2. 2 steps
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: n = 3
 * Output: 3
 * Explanation: There are three ways to climb to the top.
 * 1. 1 step + 1 step + 1 step
 * 2. 1 step + 2 steps
 * 3. 2 steps + 1 step
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= n <= 45
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int ClimbStairs(int n)
    {
        int fn0 = 1;
        int fn1 = 1;
        for (int i = 2; i <= n; i++)
        {
            int t = fn0 + fn1;
            fn0 = fn1;
            fn1 = t;
        }
        return fn1;
    }
}
// @lc code=end

