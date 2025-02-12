/*
 * @lc app=leetcode id=344 lang=csharp
 *
 * [344] Reverse String
 *
 * https://leetcode.com/problems/reverse-string/description/
 *
 * algorithms
 * Easy (77.35%)
 * Likes:    8777
 * Dislikes: 1184
 * Total Accepted:    2.9M
 * Total Submissions: 3.7M
 * Testcase Example:  '["h","e","l","l","o"]'
 *
 * Write a function that reverses a string. The input string is given as an
 * array of characters s.
 * 
 * You must do this by modifying the input array in-place with O(1) extra
 * memory.
 * 
 * 
 * Example 1:
 * Input: s = ["h","e","l","l","o"]
 * Output: ["o","l","l","e","h"]
 * Example 2:
 * Input: s = ["H","a","n","n","a","h"]
 * Output: ["h","a","n","n","a","H"]
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= s.length <= 10^5
 * s[i] is a printable ascii character.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public void ReverseString(char[] s)
    {
        int length = s.Length;
        int mid = length / 2;
        for (int i = 0; i < mid; i++)
        {
            char t = s[i];
            s[i] = s[length - i - 1];
            s[length - i - 1] = t;
        }
    }
}
// @lc code=end

