/*
 * @lc app=leetcode id=389 lang=csharp
 *
 * [389] Find the Difference
 *
 * https://leetcode.com/problems/find-the-difference/description/
 *
 * algorithms
 * Easy (60.26%)
 * Likes:    5082
 * Dislikes: 487
 * Total Accepted:    815.8K
 * Total Submissions: 1.4M
 * Testcase Example:  '"abcd"\n"abcde"'
 *
 * You are given two strings s and t.
 * 
 * String t is generated by random shuffling string s and then add one more
 * letter at a random position.
 * 
 * Return the letter that was added to t.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "abcd", t = "abcde"
 * Output: "e"
 * Explanation: 'e' is the letter that was added.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "", t = "y"
 * Output: "y"
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 0 <= s.length <= 1000
 * t.length == s.length + 1
 * s and t consist of lowercase English letters.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        char result = '\0';
        foreach (char c in s) result ^= c;
        foreach (char c in t) result ^= c;
        return result;
    }
}
// @lc code=end

