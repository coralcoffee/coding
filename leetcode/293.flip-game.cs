/*
 * @lc app=leetcode id=293 lang=csharp
 *
 * [293] Flip Game
 *
 * https://leetcode.com/problems/flip-game/description/
 *
 * algorithms
 * Easy (63.49%)
 * Likes:    230
 * Dislikes: 468
 * Total Accepted:    75.3K
 * Total Submissions: 116.2K
 * Testcase Example:  '"++++"'
 *
 * You are playing a Flip Game with your friend.
 * 
 * You are given a string currentState that contains only '+' and '-'. You and
 * your friend take turns to flip two consecutive "++" into "--". The game ends
 * when a person can no longer make a move, and therefore the other person will
 * be the winner.
 * 
 * Return all possible states of the string currentState after one valid move.
 * You may return the answer in any order. If there is no valid move, return an
 * empty list [].
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: currentState = "++++"
 * Output: ["--++","+--+","++--"]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: currentState = "+"
 * Output: []
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= currentState.length <= 500
 * currentState[i] is either '+' or '-'.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public IList<string> GeneratePossibleNextMoves(string currentState)
    {
        if (currentState.Length < 2) return new List<string>();

        List<string> result = new List<string>();

        for (int i = 0; i < currentState.Length - 1; i++)
        {
            // Look for consecutive "++"
            if (currentState[i] == '+' && currentState[i + 1] == '+')
            {
                char[] array = currentState.ToCharArray();
                array[i] = '-';
                array[i + 1] = '-';
                result.Add(new string(array));
            }
        }

        return result;
    }
}
// @lc code=end

