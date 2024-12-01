/*
 * @lc app=leetcode id=500 lang=csharp
 *
 * [500] Keyboard Row
 *
 * https://leetcode.com/problems/keyboard-row/description/
 *
 * algorithms
 * Easy (70.12%)
 * Likes:    1655
 * Dislikes: 1140
 * Total Accepted:    255.4K
 * Total Submissions: 356.6K
 * Testcase Example:  '["Hello","Alaska","Dad","Peace"]'
 *
 * Given an array of strings words, return the words that can be typed using
 * letters of the alphabet on only one row of American keyboard like the image
 * below.
 * 
 * Note that the strings are case-insensitive, both lowercased and uppercased
 * of the same letter are treated as if they are at the same row.
 * 
 * In the American keyboard:
 * 
 * 
 * the first row consists of the characters "qwertyuiop",
 * the second row consists of the characters "asdfghjkl", and
 * the third row consists of the characters "zxcvbnm".
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: words = ["Hello","Alaska","Dad","Peace"]
 * 
 * Output: ["Alaska","Dad"]
 * 
 * Explanation:
 * 
 * Both "a" and "A" are in the 2nd row of the American keyboard due to case
 * insensitivity.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: words = ["omk"]
 * 
 * Output: []
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: words = ["adsdf","sfd"]
 * 
 * Output: ["adsdf","sfd"]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= words.length <= 20
 * 1 <= words[i].length <= 100
 * words[i] consists of English letters (both lowercase and uppercase). 
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public string[] FindWords(string[] words)
    {
        int[] row = new int[26];
        foreach (char c in "qwertyuiop".ToCharArray())
        {
            row[c - 'a'] = 1;
        }
        foreach (char c in "asdfghjkl".ToCharArray())
        {
            row[c - 'a'] = 2;
        }
        foreach (char c in "zxcvbnm".ToCharArray())
        {
            row[c - 'a'] = 3;
        }
        List<string> result = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            string s = words[i].ToLower();
            int k = row[s[0] - 'a'];
            bool isSame = true;
            foreach (char c in s)
            {
                if (row[c - 'a'] != k)
                {
                    isSame = false;
                    break;
                }
            }
            if (isSame)
            {
                result.Add(words[i]);
            }
        }
        return result.ToArray();
    }
}
// @lc code=end

