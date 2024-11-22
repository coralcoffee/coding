/*
 * @lc app=leetcode id=387 lang=csharp
 *
 * [387] First Unique Character in a String
 *
 * https://leetcode.com/problems/first-unique-character-in-a-string/description/
 *
 * algorithms
 * Easy (60.28%)
 * Likes:    9085
 * Dislikes: 304
 * Total Accepted:    1.8M
 * Total Submissions: 2.9M
 * Testcase Example:  '"leetcode"'
 *
 * Given a string s, find the first non-repeating character in it and return
 * its index. If it does not exist, return -1.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "leetcode"
 * 
 * Output: 0
 * 
 * Explanation:
 * 
 * The character 'l' at index 0 is the first character that does not occur at
 * any other index.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "loveleetcode"
 * 
 * Output: 2
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: s = "aabb"
 * 
 * Output: -1
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= s.length <= 10^5
 * s consists of only lowercase English letters.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int FirstUniqChar(string s)
    {
        HashSet<char> set = new HashSet<char>();
        Dictionary<char, int> map = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (set.Contains(c))
            {
                map.Remove(c);
            }
            else
            {
                set.Add(c);
                map.Add(c, i);
            }
        }
        if (map.Values.Count == 0) return -1;
        int result = s.Length;
        foreach (var v in map.Values)
        {
            result = Math.Min(result, v);
        }
        return result;
    }
}
// @lc code=end

