/*
 * @lc app=leetcode id=461 lang=csharp
 *
 * [461] Hamming Distance
 *
 * https://leetcode.com/problems/hamming-distance/description/
 *
 * algorithms
 * Easy (75.19%)
 * Likes:    3881
 * Dislikes: 221
 * Total Accepted:    604.4K
 * Total Submissions: 798K
 * Testcase Example:  '1\n4'
 *
 * The Hamming distance between two integers is the number of positions at
 * which the corresponding bits are different.
 * 
 * Given two integers x and y, return the Hamming distance between them.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: x = 1, y = 4
 * Output: 2
 * Explanation:
 * 1   (0 0 0 1)
 * 4   (0 1 0 0)
 * ⁠      ↑   ↑
 * The above arrows point to positions where the corresponding bits are
 * different.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: x = 3, y = 1
 * Output: 1
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 0 <= x, y <= 2^31 - 1
 * 
 * 
 * 
 * Note: This question is the same as  2220: Minimum Bit Flips to Convert
 * Number.
 * 
 */

// @lc code=start
public class Solution
{
    public int HammingDistance(int x, int y)
    {
        int result = 0;
        while (x > 0 || y > 0)
        {
            if (x % 2 != y % 2)
            {
                result++;
            }
            x = x >> 1;
            y = y >> 1;
        }
        return result;
    }
}
// @lc code=end

