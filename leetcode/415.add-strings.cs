/*
 * @lc app=leetcode id=415 lang=csharp
 *
 * [415] Add Strings
 *
 * https://leetcode.com/problems/add-strings/description/
 *
 * algorithms
 * Easy (51.85%)
 * Likes:    5139
 * Dislikes: 772
 * Total Accepted:    748.4K
 * Total Submissions: 1.4M
 * Testcase Example:  '"11"\n"123"'
 *
 * Given two non-negative integers, num1 and num2 represented as string, return
 * the sum of num1 and num2 as a string.
 * 
 * You must solve the problem without using any built-in library for handling
 * large integers (such as BigInteger). You must also not convert the inputs to
 * integers directly.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: num1 = "11", num2 = "123"
 * Output: "134"
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: num1 = "456", num2 = "77"
 * Output: "533"
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: num1 = "0", num2 = "0"
 * Output: "0"
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= num1.length, num2.length <= 10^4
 * num1 and num2 consist of only digits.
 * num1 and num2 don't have any leading zeros except for the zero itself.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        int carry = 0;
        int n1Length = num1.Length, n2Length = num2.Length;
        int maxLength = Math.Max(n1Length, n2Length);
        char[] result = new char[maxLength + 1];
        int index = maxLength;

        for (int i = 0; i < maxLength; i++)
        {
            int n1 = i < n1Length ? num1[n1Length - 1 - i] - '0' : 0;
            int n2 = i < n2Length ? num2[n2Length - 1 - i] - '0' : 0;
            int sum = n1 + n2 + carry;
            carry = sum / 10;
            result[index--] = (char)((sum % 10) + '0');
        }

        if (carry > 0)
        {
            result[index] = (char)(carry + '0');
            return new string(result);
        }

        return new string(result).TrimStart('\0');
    }
}
// @lc code=end

