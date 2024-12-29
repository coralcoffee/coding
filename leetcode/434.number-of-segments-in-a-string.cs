/*
 * @lc app=leetcode id=434 lang=csharp
 *
 * [434] Number of Segments in a String
 *
 * https://leetcode.com/problems/number-of-segments-in-a-string/description/
 *
 * algorithms
 * Easy (36.57%)
 * Likes:    811
 * Dislikes: 1290
 * Total Accepted:    208.5K
 * Total Submissions: 574.7K
 * Testcase Example:  '"Hello, my name is John"'
 *
 * Given a string s, return the number of segments in the string.
 * 
 * A segment is defined to be a contiguous sequence of non-space characters.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "Hello, my name is John"
 * Output: 5
 * Explanation: The five segments are ["Hello,", "my", "name", "is", "John"]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "Hello"
 * Output: 1
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 0 <= s.length <= 300
 * s consists of lowercase and uppercase English letters, digits, or one of the
 * following characters "!@#$%^&*()_+-=',.:".
 * The only space character in s is ' '.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int CountSegments(string s)
    {
        return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
// @lc code=end

