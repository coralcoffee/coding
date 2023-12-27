/*
 * @lc app=leetcode id=1578 lang=csharp
 *
 * [1578] Minimum Time to Make Rope Colorful
 *
 * https://leetcode.com/problems/minimum-time-to-make-rope-colorful/description/
 *
 * algorithms
 * Medium (62.99%)
 * Likes:    3632
 * Dislikes: 125
 * Total Accepted:    229.4K
 * Total Submissions: 359.1K
 * Testcase Example:  '"abaac"\n[1,2,3,4,5]'
 *
 * Alice has n balloons arranged on a rope. You are given a 0-indexed string
 * colors where colors[i] is the color of the i^th balloon.
 * 
 * Alice wants the rope to be colorful. She does not want two consecutive
 * balloons to be of the same color, so she asks Bob for help. Bob can remove
 * some balloons from the rope to make it colorful. You are given a 0-indexed
 * integer array neededTime where neededTime[i] is the time (in seconds) that
 * Bob needs to remove the i^th balloon from the rope.
 * 
 * Return the minimum time Bob needs to make the rope colorful.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: colors = "abaac", neededTime = [1,2,3,4,5]
 * Output: 3
 * Explanation: In the above image, 'a' is blue, 'b' is red, and 'c' is green.
 * Bob can remove the blue balloon at index 2. This takes 3 seconds.
 * There are no longer two consecutive balloons of the same color. Total time =
 * 3.
 * 
 * Example 2:
 * 
 * 
 * Input: colors = "abc", neededTime = [1,2,3]
 * Output: 0
 * Explanation: The rope is already colorful. Bob does not need to remove any
 * balloons from the rope.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: colors = "aabaa", neededTime = [1,2,3,4,1]
 * Output: 2
 * Explanation: Bob will remove the ballons at indices 0 and 4. Each ballon
 * takes 1 second to remove.
 * There are no longer two consecutive balloons of the same color. Total time =
 * 1 + 1 = 2.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * n == colors.length == neededTime.length
 * 1 <= n <= 10^5
 * 1 <= neededTime[i] <= 10^4
 * colors contains only lowercase English letters.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int MinCost(string colors, int[] neededTime)
    {
        int result = 0;
        int maxCostInGroup = 0;
        int currentSum = 0;
        for (int i = 0; i < colors.Length; i++)
        {
            if (i == 0 || colors[i] != colors[i - 1])
            {
                result += currentSum - maxCostInGroup;
                currentSum = 0;
                maxCostInGroup = 0;
            }
            currentSum += neededTime[i];
            maxCostInGroup = Math.Max(maxCostInGroup, neededTime[i]);
        }
        result += currentSum - maxCostInGroup;
        return result;
    }
}
// @lc code=end

