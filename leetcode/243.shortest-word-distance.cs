/*
 * @lc app=leetcode id=243 lang=csharp
 *
 * [243] Shortest Word Distance
 *
 * https://leetcode.com/problems/shortest-word-distance/description/
 *
 * algorithms
 * Easy (65.15%)
 * Likes:    1275
 * Dislikes: 117
 * Total Accepted:    222K
 * Total Submissions: 338.5K
 * Testcase Example:  '["practice", "makes", "perfect", "coding", "makes"]\n"coding"\n"practice"'
 *
 * Given an array of strings wordsDict and two different strings that already
 * exist in the array word1 and word2, return the shortest distance between
 * these two words in the list.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: wordsDict = ["practice", "makes", "perfect", "coding", "makes"],
 * word1 = "coding", word2 = "practice"
 * Output: 3
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: wordsDict = ["practice", "makes", "perfect", "coding", "makes"],
 * word1 = "makes", word2 = "coding"
 * Output: 1
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 2 <= wordsDict.length <= 3 * 10^4
 * 1 <= wordsDict[i].length <= 10
 * wordsDict[i] consists of lowercase English letters.
 * word1 and word2 are in wordsDict.
 * word1 != word2
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int ShortestDistance(string[] wordsDict, string word1, string word2)
    {
        int distance = int.MaxValue;
        int index1 = -1, index2 = -1;
        for (int i = 0; i < wordsDict.Length; i++)
        {
            string word = wordsDict[i];
            if (word == word1)
            {
                index1 = i;
            }
            else if (word == word2)
            {
                index2 = i;
            }
            if (index1 != -1 && index2 != -1)
            {
                distance = Math.Min(distance, Math.Abs(index1 - index2));
            }
        }
        return distance;
    }
}
// @lc code=end

