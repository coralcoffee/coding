/*
 * @lc app=leetcode id=401 lang=csharp
 *
 * [401] Binary Watch
 *
 * https://leetcode.com/problems/binary-watch/description/
 *
 * algorithms
 * Easy (53.31%)
 * Likes:    1433
 * Dislikes: 2632
 * Total Accepted:    154.7K
 * Total Submissions: 278.9K
 * Testcase Example:  '1'
 *
 * A binary watch has 4 LEDs on the top to represent the hours (0-11), and 6
 * LEDs on the bottom to represent the minutes (0-59). Each LED represents a
 * zero or one, with the least significant bit on the right.
 * 
 * 
 * For example, the below binary watch reads "4:51".
 * 
 * 
 * 
 * 
 * Given an integer turnedOn which represents the number of LEDs that are
 * currently on (ignoring the PM), return all possible times the watch could
 * represent. You may return the answer in any order.
 * 
 * The hour must not contain a leading zero.
 * 
 * 
 * For example, "01:00" is not valid. It should be "1:00".
 * 
 * 
 * The minute must consist of two digits and may contain a leading zero.
 * 
 * 
 * For example, "10:2" is not valid. It should be "10:02".
 * 
 * 
 * 
 * Example 1:
 * Input: turnedOn = 1
 * Output:
 * ["0:01","0:02","0:04","0:08","0:16","0:32","1:00","2:00","4:00","8:00"]
 * Example 2:
 * Input: turnedOn = 9
 * Output: []
 * 
 * 
 * Constraints:
 * 
 * 
 * 0 <= turnedOn <= 10
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        if (turnedOn > 8 || turnedOn <= 0) return [];
        var result = new List<string>();
        int[] hours = [8, 4, 2, 1];
        int[] minutes = [32, 16, 8, 4, 2, 1];
        for (int i = 0; i <= turnedOn; i++)
        {
            int j = turnedOn - i;

        }
        return result;
    }
    void GenerateCombinations(int[] array, int combinationSize, int startIndex, List<int> currentCombination, List<List<int>> result)
    {
        // Base case: if the combination is the desired size, add it to the result
        if (currentCombination.Count == combinationSize)
        {
            result.Add(new List<int>(currentCombination));
            return;
        }

        // Recursive case: generate combinations
        for (int i = startIndex; i < array.Length; i++)
        {
            currentCombination.Add(array[i]);
            GenerateCombinations(array, combinationSize, i + 1, currentCombination, result);
            currentCombination.RemoveAt(currentCombination.Count - 1); // Backtrack
        }
    }

}
// @lc code=end

