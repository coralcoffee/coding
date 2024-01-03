/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 *
 * https://leetcode.com/problems/valid-parentheses/description/
 *
 * algorithms
 * Easy (40.20%)
 * Likes:    22997
 * Dislikes: 1608
 * Total Accepted:    4.1M
 * Total Submissions: 10.2M
 * Testcase Example:  '"()"'
 *
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and
 * ']', determine if the input string is valid.
 * 
 * An input string is valid if:
 * 
 * 
 * Open brackets must be closed by the same type of brackets.
 * Open brackets must be closed in the correct order.
 * Every close bracket has a corresponding open bracket of the same type.
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "()"
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "()[]{}"
 * Output: true
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: s = "(]"
 * Output: false
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= s.length <= 10^4
 * s consists of parentheses only '()[]{}'.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public bool IsValid(string s)
    {
        var bracketMap = new Dictionary<char, char> {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (bracketMap.ContainsKey(c))
            {
                if (stack.Count == 0 || stack.Pop() != bracketMap[c]) return false;
            }
            else
            {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}
// @lc code=end

