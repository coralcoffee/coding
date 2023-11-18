/*
 * @lc app=leetcode id=5 lang=typescript
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
function longestPalindrome(s: string): string {
  if (s.length < 2) return s;
  let startIndex = 0,
    endIndex = 0;
  let left = 0,
    right = 0;
  for (let i = 0; i < s.length; i++) {
    left = i;
    right = i;
    while (s[left] === s[right + 1]) right++;
    while (left >= 0 && right < s.length && s[left - 1] === s[right + 1]) {
      left--;
      right++;
    }
    if (right - left > endIndex - startIndex) {
      startIndex = left;
      endIndex = right;
    }
  }
  return s.substring(startIndex, endIndex + 1);
}
// @lc code=end
