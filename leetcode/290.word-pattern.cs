/*
 * @lc app=leetcode id=290 lang=csharp
 *
 * [290] Word Pattern
 *
 * https://leetcode.com/problems/word-pattern/description/
 *
 * algorithms
 * Easy (41.73%)
 * Likes:    6988
 * Dislikes: 924
 * Total Accepted:    636.6K
 * Total Submissions: 1.5M
 * Testcase Example:  '"abba"\n"dog cat cat dog"'
 *
 * Given a pattern and a string s, find if s follows the same pattern.
 * 
 * Here follow means a full match, such that there is a bijection between a
 * letter in pattern and a non-empty word in s.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: pattern = "abba", s = "dog cat cat dog"
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: pattern = "abba", s = "dog cat cat fish"
 * Output: false
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: pattern = "aaaa", s = "dog cat cat dog"
 * Output: false
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= pattern.length <= 300
 * pattern contains only lower-case English letters.
 * 1 <= s.length <= 3000
 * s contains only lowercase English letters and spaces ' '.
 * s does not contain any leading or trailing spaces.
 * All the words in s are separated by a single space.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var wordToChar = new Dictionary<string, char>();
        var charToWord = new Dictionary<char, string>();
        int indexP = 0;
        int startIndex = 0;
        for (int i = 0; i <= s.Length; i++)
        {
            if (indexP > pattern.Length - 1) return false;
            if (i == s.Length || s[i] == 32)
            {
                string sub = s.Substring(startIndex, i - startIndex);
                if (charToWord.ContainsKey(pattern[indexP]))
                {
                    if (charToWord[pattern[indexP]] != sub) return false;
                }
                else
                {
                    if (wordToChar.ContainsKey(sub)) return false;
                    charToWord[pattern[indexP]] = sub;
                    wordToChar[sub] = pattern[indexP];
                }
                indexP++;
                startIndex = i + 1;
            }
        }
        return indexP == pattern.Length;
    }
}
// @lc code=end

