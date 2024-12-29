/*
 * @lc app=leetcode id=266 lang=csharp
 *
 * [266] Palindrome Permutation
 *
 * https://leetcode.com/problems/palindrome-permutation/description/
 *
 * algorithms
 * Easy (66.47%)
 * Likes:    1072
 * Dislikes: 73
 * Total Accepted:    214.2K
 * Total Submissions: 315.6K
 * Testcase Example:  '"code"'
 *
 * Given a string s, return true if a permutation of the string could form a
 * palindrome and false otherwise.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "code"
 * Output: false
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "aab"
 * Output: true
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: s = "carerac"
 * Output: true
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= s.length <= 5000
 * s consists of only lowercase English letters.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public bool CanPermutePalindrome(string s)
    {
        int[] charCounts = new int[26];
        foreach (char c in s)
        {
            charCounts[c - 'a']++;
        }
        int totalOdd = 0;
        foreach (int count in charCounts)
        {
            if (count % 2 != 0)
            {
                totalOdd++;
                if (totalOdd > 1) return false;
            }
        }

        return true;
    }
}
// @lc code=end

