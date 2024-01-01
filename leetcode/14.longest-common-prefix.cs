/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 *
 * https://leetcode.com/problems/longest-common-prefix/description/
 *
 * algorithms
 * Easy (41.76%)
 * Likes:    16612
 * Dislikes: 4370
 * Total Accepted:    2.9M
 * Total Submissions: 7M
 * Testcase Example:  '["flower","flow","flight"]'
 *
 * Write a function to find the longest common prefix string amongst an array
 * of strings.
 * 
 * If there is no common prefix, return an empty string "".
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: strs = ["flower","flow","flight"]
 * Output: "fl"
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: strs = ["dog","racecar","car"]
 * Output: ""
 * Explanation: There is no common prefix among the input strings.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= strs.length <= 200
 * 0 <= strs[i].length <= 200
 * strs[i] consists of only lowercase English letters.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var result = new StringBuilder();
        int index = 0;
        while (true)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                if (index >= strs[i].Length || strs[i][index] != strs[0][index])
                {
                    return result.ToString();
                }
            }
            result.Append(strs[0][index]);
            index++;
        }
        return result.ToString();
    }
}
// @lc code=end

