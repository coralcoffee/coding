/*
 * @lc app=leetcode id=43 lang=csharp
 *
 * [43] Multiply Strings
 *
 * https://leetcode.com/problems/multiply-strings/description/
 *
 * algorithms
 * Medium (39.61%)
 * Likes:    7205
 * Dislikes: 3429
 * Total Accepted:    884.5K
 * Total Submissions: 2.1M
 * Testcase Example:  '"2"\n"3"'
 *
 * Given two non-negative integers num1 and num2 represented as strings, return
 * the product of num1 and num2, also represented as a string.
 * 
 * Note: You must not use any built-in BigInteger library or convert the inputs
 * to integer directly.
 * 
 * 
 * Example 1:
 * Input: num1 = "2", num2 = "3"
 * Output: "6"
 * Example 2:
 * Input: num1 = "123", num2 = "456"
 * Output: "56088"
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= num1.length, num2.length <= 200
 * num1 and num2 consist of digits only.
 * Both num1 and num2 do not contain any leading zero, except the number 0
 * itself.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0") return "0";
        int[] numbers = new int[num1.Length + num2.Length];

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            int n1 = num1[i] - '0';
            if (n1 == 0) continue;
            int carry = 0;
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                int n2 = num2[j] - '0';
                int index = i + j + 1;
                int sum = n1 * n2 + numbers[index] + carry;
                carry = sum / 10;
                numbers[index] = sum % 10;
            }
            numbers[i] += carry;
        }

        var result = new StringBuilder();
        bool leadingZero = true;
        foreach (var num in numbers)
        {
            if (leadingZero && num == 0) continue;
            leadingZero = false;
            result.Append(num);
        }

        return result.ToString();
    }
}
// @lc code=end

