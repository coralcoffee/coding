/*
 * @lc app=leetcode id=3 lang=csharp
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
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var dict = new Dictionary<char, int>();
        int result = 0;
        int start = -1;
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
                start = Math.Max(start, dict[s[i]]);
            result = Math.Max(result, i - start);
            dict[s[i]] = i;
        }
        return result;
    }
}
// @lc code=end

