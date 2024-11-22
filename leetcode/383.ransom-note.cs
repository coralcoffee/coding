/*
 * @lc app=leetcode id=383 lang=csharp
 *
 * [383] Ransom Note
 *
 * https://leetcode.com/problems/ransom-note/description/
 *
 * algorithms
 * Easy (59.86%)
 * Likes:    5137
 * Dislikes: 513
 * Total Accepted:    1.4M
 * Total Submissions: 2.2M
 * Testcase Example:  '"a"\n"b"'
 *
 * Given two strings ransomNote and magazine, return true if ransomNote can be
 * constructed by using the letters from magazine and false otherwise.
 * 
 * Each letter in magazine can only be used once in ransomNote.
 * 
 * 
 * Example 1:
 * Input: ransomNote = "a", magazine = "b"
 * Output: false
 * Example 2:
 * Input: ransomNote = "aa", magazine = "ab"
 * Output: false
 * Example 3:
 * Input: ransomNote = "aa", magazine = "aab"
 * Output: true
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= ransomNote.length, magazine.length <= 10^5
 * ransomNote and magazine consist of lowercase English letters.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        int[] array = new int[26];
        foreach (char c in magazine)
        {
            array[c - 'a']++;
        }
        foreach (char c in ransomNote)
        {
            if (--array[c - 'a'] < 0) return false;
        }
        return true;
    }
    public bool CanConstruct1(string ransomNote, string magazine)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        foreach (char c in ransomNote)
        {
            if (map.TryGetValue(c, out int count))
            {
                map[c] = count + 1;
            }
            else
            {
                map[c] = 1;
            }
        }
        foreach (char c in magazine)
        {
            if (map.Keys.Count == 0)
            {
                return true;
            }
            if (map.TryGetValue(c, out int count))
            {
                if (count == 1)
                {
                    map.Remove(c);
                }
                else
                {
                    map[c] = count - 1;
                }
            }
        }
        return map.Keys.Count == 0;
    }
}
// @lc code=end

