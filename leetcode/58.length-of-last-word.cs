/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 *
 * https://leetcode.com/problems/length-of-last-word/description/
 *
 * algorithms
 * Easy (46.96%)
 * Likes:    4425
 * Dislikes: 232
 * Total Accepted:    1.5M
 * Total Submissions: 3.2M
 * Testcase Example:  '"Hello World"'
 *
 * Given a string s consisting of words and spaces, return the length of the
 * last word in the string.
 * 
 * A word is a maximal substring consisting of non-space characters only.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "Hello World"
 * Output: 5
 * Explanation: The last word is "World" with length 5.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "   fly me   to   the moon  "
 * Output: 4
 * Explanation: The last word is "moon" with length 4.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: s = "luffy is still joyboy"
 * Output: 6
 * Explanation: The last word is "joyboy" with length 6.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= s.length <= 10^4
 * s consists of only English letters and spaces ' '.
 * There will be at least one word in s.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int k = s.Length - 1;
        while (k >= 0 && s[k] == ' ')
        {
            k--;
        }
        for (int i = k; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                return k - i;
            }
        }
        return k + 1;
    }
}
// @lc code=end

