/*
 * @lc app=leetcode id=459 lang=csharp
 *
 * [459] Repeated Substring Pattern
 *
 * https://leetcode.com/problems/repeated-substring-pattern/description/
 *
 * algorithms
 * Easy (46.05%)
 * Likes:    6498
 * Dislikes: 536
 * Total Accepted:    490.8K
 * Total Submissions: 1.1M
 * Testcase Example:  '"abab"'
 *
 * Given a string s, check if it can be constructed by taking a substring of it
 * and appending multiple copies of the substring together.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "abab"
 * Output: true
 * Explanation: It is the substring "ab" twice.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "aba"
 * Output: false
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: s = "abcabcabcabc"
 * Output: true
 * Explanation: It is the substring "abc" four times or the substring "abcabc"
 * twice.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= s.length <= 10^4
 * s consists of lowercase English letters.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        int length = 1;
        while (length <= s.Length / 2)
        {
            if (s.Length % length != 0)
            {
                length++;
                continue;
            }
            string sub = s.Substring(0, length);
            bool isSame = true;
            for (int i = length; i < s.Length; i++)
            {
                int index = i % length;
                if (sub[index] != s[i])
                {
                    isSame = false;
                    break;
                }
            }
            if (isSame) return true;
            length++;
        }
        return false;
    }
}
// @lc code=end

