/*
 * @lc app=leetcode id=3 lang=typescript
 *
 * [3] Longest Substring Without Repeating Characters
 *
 * https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
 *
 * algorithms
 * Medium (34.13%)
 * Likes:    37782
 * Dislikes: 1710
 * Total Accepted:    5.1M
 * Total Submissions: 14.9M
 * Testcase Example:  '"abcabcbb"'
 *
 * Given a string s, find the length of the longest substring without repeating
 * characters.
 *
 *
 * Example 1:
 *
 *
 * Input: s = "abcabcbb"
 * Output: 3
 * Explanation: The answer is "abc", with the length of 3.
 *
 *
 * Example 2:
 *
 *
 * Input: s = "bbbbb"
 * Output: 1
 * Explanation: The answer is "b", with the length of 1.
 *
 *
 * Example 3:
 *
 *
 * Input: s = "pwwkew"
 * Output: 3
 * Explanation: The answer is "wke", with the length of 3.
 * Notice that the answer must be a substring, "pwke" is a subsequence and not
 * a substring.
 *
 *
 *
 * Constraints:
 *
 *
 * 0 <= s.length <= 5 * 10^4
 * s consists of English letters, digits, symbols and spaces.
 *
 *
 */

// @lc code=start
function lengthOfLongestSubstring(s: string): number {
    let result = 0;
    let start = 0;
    const dict = new Map();
    for (let i = 0; i < s.length; i++) {
        if (dict.has(s[i])) {
            start = Math.max(start, dict.get(s[i]) + 1);
        }
        result = Math.max(result, i - start + 1);
        dict.set(s[i], i);
    }
    return result;
}
// @lc code=end
