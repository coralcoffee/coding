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
        if (string.IsNullOrEmpty(s)) return "";
        int startIndex = 0, maxLength = 0;
        int i = 0;
        while (i < s.Length)
        {
            int left = i, right = i;
            while (right < s.Length && s[left] == s[right])
            {
                right++;
                i++;
            }
            left--;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            int currentLength = right - left - 1;
            if (currentLength > maxLength)
            {
                startIndex = left + 1;
                maxLength = currentLength;
            }
        }
        return s.Substring(startIndex, maxLength);
    }
}
// @lc code=end

