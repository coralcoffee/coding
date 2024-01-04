/*
 * @lc app=leetcode id=22 lang=csharp
 *
 * [22] Generate Parentheses
 *
 * https://leetcode.com/problems/generate-parentheses/description/
 *
 * algorithms
 * Medium (73.63%)
 * Likes:    20266
 * Dislikes: 855
 * Total Accepted:    1.7M
 * Total Submissions: 2.2M
 * Testcase Example:  '3'
 *
 * Given n pairs of parentheses, write a function to generate all combinations
 * of well-formed parentheses.
 * 
 * 
 * Example 1:
 * Input: n = 3
 * Output: ["((()))","(()())","(())()","()(())","()()()"]
 * Example 2:
 * Input: n = 1
 * Output: ["()"]
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= n <= 8
 * 
 * 
 */

// @lc code=start
public class Solution
{
    private readonly List<string> _result = new List<string>();
    public IList<string> GenerateParenthesis(int n)
    {
        Generate(n, "", 0, 0);
        return _result;
    }

    private void Generate(int n, string str, int left = 0, int right = 0)
    {
        if (str.Length == 2 * n)
        {
            _result.Add(str);
            return;
        }

        if (left < n)
        {
            Generate(n, str + "(", left + 1, right);
        }
        if (left > right)
        {
            Generate(n, str + ")", left, right + 1);
        }
    }
}
// @lc code=end

