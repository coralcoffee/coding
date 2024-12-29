/*
 * @lc app=leetcode id=408 lang=csharp
 *
 * [408] Valid Word Abbreviation
 *
 * https://leetcode.com/problems/valid-word-abbreviation/description/
 *
 * algorithms
 * Easy (35.10%)
 * Likes:    796
 * Dislikes: 2302
 * Total Accepted:    251.2K
 * Total Submissions: 691.2K
 * Testcase Example:  '"internationalization"\n"i12iz4n"'
 *
 * A string can be abbreviated by replacing any number of non-adjacent,
 * non-empty substrings with their lengths. The lengths should not have leading
 * zeros.
 * 
 * For example, a string such as "substitution" could be abbreviated as (but
 * not limited to):
 * 
 * 
 * "s10n" ("s ubstitutio n")
 * "sub4u4" ("sub stit u tion")
 * "12" ("substitution")
 * "su3i1u2on" ("su bst i t u ti on")
 * "substitution" (no substrings replaced)
 * 
 * 
 * The following are not valid abbreviations:
 * 
 * 
 * "s55n" ("s ubsti tutio n", the replaced substrings are adjacent)
 * "s010n" (has leading zeros)
 * "s0ubstitution" (replaces an empty substring)
 * 
 * 
 * Given a string word and an abbreviation abbr, return whether the string
 * matches the given abbreviation.
 * 
 * A substring is a contiguous non-empty sequence of characters within a
 * string.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: word = "internationalization", abbr = "i12iz4n"
 * Output: true
 * Explanation: The word "internationalization" can be abbreviated as "i12iz4n"
 * ("i nternational iz atio n").
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: word = "apple", abbr = "a2e"
 * Output: false
 * Explanation: The word "apple" cannot be abbreviated as "a2e".
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= word.length <= 20
 * word consists of only lowercase English letters.
 * 1 <= abbr.length <= 10
 * abbr consists of lowercase English letters and digits.
 * All the integers in abbr will fit in a 32-bit integer.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public bool ValidWordAbbreviation(string word, string abbr)
    {
        int index = 0;
        int count = 0;
        for (int i = 0; i < abbr.Length; i++)
        {
            char c = abbr[i];
            if (char.IsDigit(c))
            {
                if (c == '0' && count == 0)
                {
                    return false;
                }
                count = count * 10 + c - '0';
            }
            else
            {
                if (count > 0)
                {
                    index += count;
                    count = 0;
                }
                if (index >= word.Length || word[index] != c)
                {
                    return false;
                }
                index++;
            }
        }
        return index + count == word.Length;
    }
}
// @lc code=end

