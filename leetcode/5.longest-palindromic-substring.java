/*
 * @lc app=leetcode id=5 lang=java
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
class Solution {
    public String longestPalindrome(String s) {
        if (s.length() < 2)
            return s;
        int startIndex = 0, maxLength = 0;
        for (int i = 0; i < s.length(); i++) {
            int left = i, right = i;
            while (right < s.length() - 1 && s.charAt(i) == s.charAt(right + 1)) {
                right++;
            }
            while (left > 0 && right < s.length() - 1 && s.charAt(left - 1) == s.charAt(right + 1)) {
                left--;
                right++;
            }
            if (maxLength < right - left + 1) {
                startIndex = left;
                maxLength = right - left + 1;
            }
        }
        return s.substring(startIndex, startIndex+maxLength);
    }
}
// @lc code=end
