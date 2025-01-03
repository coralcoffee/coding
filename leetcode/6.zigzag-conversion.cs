/*
 * @lc app=leetcode id=6 lang=csharp
 *
 * [6] Zigzag Conversion
 *
 * https://leetcode.com/problems/zigzag-conversion/description/
 *
 * algorithms
 * Medium (46.28%)
 * Likes:    6948
 * Dislikes: 13660
 * Total Accepted:    1.2M
 * Total Submissions: 2.5M
 * Testcase Example:  '"PAYPALISHIRING"\n3'
 *
 * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number
 * of rows like this: (you may want to display this pattern in a fixed font for
 * better legibility)
 * 
 * 
 * P   A   H   N
 * A P L S I I G
 * Y   I   R
 * 
 * 
 * And then read line by line: "PAHNAPLSIIGYIR"
 * 
 * Write the code that will take a string and make this conversion given a
 * number of rows:
 * 
 * 
 * string convert(string s, int numRows);
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "PAYPALISHIRING", numRows = 3
 * Output: "PAHNAPLSIIGYIR"
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "PAYPALISHIRING", numRows = 4
 * Output: "PINALSIGYAHRPI"
 * Explanation:
 * P     I    N
 * A   L S  I G
 * Y A   H R
 * P     I
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: s = "A", numRows = 1
 * Output: "A"
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= s.length <= 1000
 * s consists of English letters (lower-case and upper-case), ',' and '.'.
 * 1 <= numRows <= 1000
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || numRows == s.Length) return s;
        StringBuilder[] sbs = new StringBuilder[numRows];
        for (int i = 0; i < numRows; i++)
        {
            sbs[i] = new StringBuilder();
        }

        int currentRow = 0;
        bool goingDown = false;
        foreach (char c in s)
        {
            sbs[currentRow].Append(c);
            if (currentRow == 0 || currentRow == numRows - 1)
                goingDown = !goingDown;
            currentRow = goingDown ? currentRow + 1 : currentRow - 1;
        }

        StringBuilder result = new StringBuilder();
        foreach (StringBuilder sb in sbs)
        {
            result.Append(sb);
        }
        return result.ToString();
    }
}
// @lc code=end

