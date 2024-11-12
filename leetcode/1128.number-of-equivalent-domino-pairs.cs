/*
 * @lc app=leetcode id=1128 lang=csharp
 *
 * [1128] Number of Equivalent Domino Pairs
 *
 * https://leetcode.com/problems/number-of-equivalent-domino-pairs/description/
 *
 * algorithms
 * Easy (47.79%)
 * Likes:    694
 * Dislikes: 335
 * Total Accepted:    73.7K
 * Total Submissions: 151.2K
 * Testcase Example:  '[[1,2],[2,1],[3,4],[5,6]]'
 *
 * Given a list of dominoes, dominoes[i] = [a, b] is equivalent to dominoes[j]
 * = [c, d] if and only if either (a == c and b == d), or (a == d and b == c) -
 * that is, one domino can be rotated to be equal to another domino.
 * 
 * Return the number of pairs (i, j) for which 0 <= i < j < dominoes.length,
 * and dominoes[i] is equivalent to dominoes[j].
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: dominoes = [[1,2],[2,1],[3,4],[5,6]]
 * Output: 1
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: dominoes = [[1,2],[1,2],[1,1],[1,2],[2,2]]
 * Output: 3
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= dominoes.length <= 4 * 10^4
 * dominoes[i].length == 2
 * 1 <= dominoes[i][j] <= 9
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        int result = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < dominoes.Length; i++)
        {
            int key = 0;
            if (dominoes[i][1] > dominoes[i][0])
            {
                key = dominoes[i][1] * 10 + dominoes[i][0];
            }
            else
            {
                key = dominoes[i][0] * 10 + dominoes[i][1];
            }
            if (dict.ContainsKey(key))
            {
                result += dict[key];
                dict[key]++;
            }
            else
            {
                dict[key] = 1;
            }
        }
        return result;
    }
}
// @lc code=end

