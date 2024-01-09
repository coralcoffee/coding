/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 *
 * https://leetcode.com/problems/add-binary/description/
 *
 * algorithms
 * Easy (52.84%)
 * Likes:    9072
 * Dislikes: 919
 * Total Accepted:    1.3M
 * Total Submissions: 2.5M
 * Testcase Example:  '"11"\n"1"'
 *
 * Given two binary strings a and b, return their sum as a binary string.
 * 
 * 
 * Example 1:
 * Input: a = "11", b = "1"
 * Output: "100"
 * Example 2:
 * Input: a = "1010", b = "1011"
 * Output: "10101"
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= a.length, b.length <= 10^4
 * a and b consist only of '0' or '1' characters.
 * Each string does not contain leading zeros except for the zero itself.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public string AddBinary(string a, string b)
    {
        StringBuilder result = new StringBuilder();
        int i = a.Length - 1, j = b.Length - 1;
        int carry = 0;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;
            if (i >= 0)
            {
                sum += a[i] - '0'; // Convert char to int
                i--;
            }
            if (j >= 0)
            {
                sum += b[j] - '0'; // Convert char to int
                j--;
            }

            result.Append(sum % 2); // Add the current digit to the result
            carry = sum / 2; // Update carry
        }

        // Reverse and return the result
        char[] resultArray = result.ToString().ToCharArray();
        Array.Reverse(resultArray);
        return new string(resultArray);
    }
}
// @lc code=end

