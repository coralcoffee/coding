/*
 * @lc app=leetcode id=246 lang=csharp
 *
 * [246] Strobogrammatic Number
 *
 * https://leetcode.com/problems/strobogrammatic-number/description/
 *
 * algorithms
 * Easy (47.65%)
 * Likes:    606
 * Dislikes: 1022
 * Total Accepted:    184.1K
 * Total Submissions: 386.3K
 * Testcase Example:  '"69"'
 *
 * Given a string num which represents an integer, return true if num is a
 * strobogrammatic number.
 * 
 * A strobogrammatic number is a number that looks the same when rotated 180
 * degrees (looked at upside down).
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: num = "69"
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: num = "88"
 * Output: true
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: num = "962"
 * Output: false
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= num.length <= 50
 * num consists of only digits.
 * num does not contain any leading zeros except for zero itself.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public bool IsStrobogrammatic(string num)
    {
        for (int i = 0; i <= num.Length / 2; i++)
        {
            char c = num[i];
            switch (c)
            {
                case '0':
                case '1':
                case '8':
                    if (num[num.Length - i - 1] != c)
                        return false;
                    break;
                case '6':
                    if (num[num.Length - i - 1] != '9')
                        return false;
                    break;
                case '9':
                    if (num[num.Length - i - 1] != '6')
                        return false;
                    break;
                default:
                    return false;
            }
        }
        return true;
    }
}
// @lc code=end

