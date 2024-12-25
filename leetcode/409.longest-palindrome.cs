/*
 * @lc app=leetcode id=409 lang=csharp
 *
 * [409] Longest Palindrome
 *
 * https://leetcode.com/problems/longest-palindrome/description/
 *
 * algorithms
 * Easy (53.89%)
 * Likes:    6000
 * Dislikes: 420
 * Total Accepted:    853.1K
 * Total Submissions: 1.5M
 * Testcase Example:  '"abccccdd"'
 *
 * Given a string s which consists of lowercase or uppercase letters, return
 * the length of the longest palindrome that can be built with those letters.
 * 
 * Letters are case sensitive, for example, "Aa" is not considered a
 * palindrome.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "abccccdd"
 * Output: 7
 * Explanation: One longest palindrome that can be built is "dccaccd", whose
 * length is 7.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "a"
 * Output: 1
 * Explanation: The longest palindrome that can be built is "a", whose length
 * is 1.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= s.length <= 2000
 * s consists of lowercase and/or uppercase English letters only.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int LongestPalindrome(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict.Add(c, 1);
            }
        }
        int count = 0;
        int hasOdd = 0;
        foreach (var v in dict.Values)
        {
            if (v % 2 == 0)
            {
                count += v;
            }
            else
            {
                count += v - 1;
                hasOdd = 1;
            }
        }
        return count + hasOdd;
    }
}
// @lc code=end

