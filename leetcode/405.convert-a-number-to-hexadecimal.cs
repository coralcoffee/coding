/*
 * @lc app=leetcode id=405 lang=csharp
 *
 * [405] Convert a Number to Hexadecimal
 *
 * https://leetcode.com/problems/convert-a-number-to-hexadecimal/description/
 *
 * algorithms
 * Easy (47.62%)
 * Likes:    1334
 * Dislikes: 224
 * Total Accepted:    161.7K
 * Total Submissions: 325.2K
 * Testcase Example:  '26'
 *
 * Given a 32-bit integer num, return a string representing its hexadecimal
 * representation. For negative integers, two’s complement method is used.
 * 
 * All the letters in the answer string should be lowercase characters, and
 * there should not be any leading zeros in the answer except for the zero
 * itself.
 * 
 * Note: You are not allowed to use any built-in library method to directly
 * solve this problem.
 * 
 * 
 * Example 1:
 * Input: num = 26
 * Output: "1a"
 * Example 2:
 * Input: num = -1
 * Output: "ffffffff"
 * 
 * 
 * Constraints:
 * 
 * 
 * -2^31 <= num <= 2^31 - 1
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public string ToHex(int num)
    {
        if (num == 0) return "0";
        uint unum = (uint)num;
        var sb = new StringBuilder();
        while (unum != 0)
        {
            var n = unum % 16;
            if (n > 9)
                sb.Insert(0, (char)(n - 10 + 'a'));
            else
                sb.Insert(0, n.ToString());
            unum = unum >> 4;
        }
        return sb.ToString();
    }
}
// @lc code=end

