/*
 * @lc app=leetcode id=6 lang=java
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
class Solution {
    public String convert(String s, int numRows) {
        if (numRows == 1 || numRows >= s.length()) {
            return s;
        }
        
        StringBuilder[] rows = new StringBuilder[numRows];
        for (int i = 0; i < numRows; i++) rows[i] = new StringBuilder();
        
        int curRow = 0;
        boolean goingDown = false;
        
        for (char c : s.toCharArray()) {
            rows[curRow].append(c);
            if (curRow == 0 || curRow == numRows - 1) goingDown = !goingDown;
            curRow += goingDown ? 1 : -1;
        }
        
        StringBuilder result = new StringBuilder();
        for (StringBuilder row : rows) result.append(row);
        
        return result.toString();
    }
}
class Solution2 {
    public String convert(String s, int numRows) {
        if (numRows <= 1)
            return s;
        int groupSize = 2 * numRows - 2;
        int groupCount = s.length() / groupSize;
        if (s.length() % groupSize != 0)
            groupCount++;
        StringBuilder sb = new StringBuilder();
        int p = 0;
        for (int i = 0; i < numRows; i++) {
            for (int j = 0; j < groupCount; j++) {
                if (i == 0 || i == numRows - 1) {
                    p = j * groupSize + i;
                    if (p < s.length())
                        sb.append(s.charAt(p));
                } else {
                    p = j * groupSize + i;
                    if (p < s.length())
                        sb.append(s.charAt(p));
                    p = (j + 1) * groupSize - i;
                    if (p < s.length())
                        sb.append(s.charAt(p));
                }
            }
        }
        return sb.toString();
    }
}

class Solution1 {
    public String convert(String s, int numRows) {
        if (numRows <= 1)
            return s;
        int groupSize = 2 * numRows - 2;
        int groupCount = s.length() / groupSize;
        if (s.length() % groupSize != 0)
            groupCount++;
        char[] charArray = new char[s.length()];
        int index = 0, p = 0;
        for (int i = 0; i < numRows; i++) {
            for (int j = 0; j < groupCount; j++) {
                if (i == 0 || i == numRows - 1) {
                    p = j * groupSize + i;
                    if (p < s.length())
                        charArray[index++] = s.charAt(p);
                } else {
                    p = j * groupSize + i;
                    if (p < s.length())
                        charArray[index++] = s.charAt(p);
                    p = (j + 1) * groupSize - i;
                    if (p < s.length())
                        charArray[index++] = s.charAt(p);
                }
            }
        }
        return new String(charArray);
    }
}
// @lc code=end
