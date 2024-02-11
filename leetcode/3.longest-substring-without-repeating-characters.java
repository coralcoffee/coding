/*
 * @lc app=leetcode id=3 lang=java
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
class Solution {
    public int lengthOfLongestSubstring(String s) {
        Map<Character, Integer> dict = new HashMap<>();
        int start = -1;
        int result = 0;
        for (int i = 0; i < s.length(); i++) {
            if (dict.containsKey(s.charAt(i))) // Fixed the indexing issue
                start = Math.max(dict.get(s.charAt(i)), start); // Fixed the indexing issue
            result = Math.max(i - start, result);
            dict.put(s.charAt(i), i); // Fixed the indexing issue
        }
        return result;
    }
}
// @lc code=end
