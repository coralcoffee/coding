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
        if (numRows <= 1) return s;

        int groupSize = numRows * 2 - 2;
        int groupCount = (s.Length + groupSize - 1) / groupSize;
        var result = new char[s.Length];
        int index = 0;
        for (int i = 0; i < groupCount; i++)
        {
            result[index] = s[i * groupSize];
            index++;
        }
        for (int j = 1; j < numRows - 1; j++)
        {
            for (int i = 0; i < groupCount; i++)
            {
                int p = groupSize * i + j;
                if (p < s.Length)
                {
                    result[index] = s[p];
                    index++;
                }
                p = groupSize * (i + 1) - j;
                if (p < s.Length)
                {
                    result[index] = s[p];
                    index++;
                }
            }

        }
        for (int i = 0; i < groupCount; i++)
        {
            int p = i * groupSize + numRows - 1;
            if (p < s.Length)
            {
                result[index] = s[p];
                index++;
            }
        }
        return new string(result);
    }
}
// @lc code=end

