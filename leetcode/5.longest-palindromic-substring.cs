/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 *
 * https://leetcode.com/problems/longest-palindromic-substring/description/
 *
 * algorithms
 * Medium (33.25%)
 * Likes:    28008
 * Dislikes: 1660
 * Total Accepted:    2.7M
 * Total Submissions: 8.3M
 * Testcase Example:  '"babad"'
 *
 * Given a string s, return the longest palindromic substring in s.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "babad"
 * Output: "bab"
 * Explanation: "aba" is also a valid answer.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "cbbd"
 * Output: "bb"
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= s.length <= 1000
 * s consist of only digits and English letters.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public string LongestPalindrome(string s)
    {
        int startIndex = 0, start = 0, end = 0;
        int maxLength = 0;
        for (int i = 0; i < s.Length; i++)
        {
            start = i;
            end = i;
            while (end < s.Length - 1 && s[start] == s[end + 1])
                end++;
            while (start > 0 && end < s.Length - 1 && s[start - 1] == s[end + 1])
            {
                start--;
                end++;
            }
            if (maxLength < end - start + 1)
            {
                maxLength = end - start + 1;
                startIndex = start;
            }
        }
        return s.Substring(startIndex, maxLength);
    }
}
// @lc code=end

