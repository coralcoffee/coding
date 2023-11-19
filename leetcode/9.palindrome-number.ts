/*
 * @lc app=leetcode id=9 lang=typescript
 *
 * [9] Palindrome Number
 *
 * https://leetcode.com/problems/palindrome-number/description/
 *
 * algorithms
 * Easy (54.77%)
 * Likes:    11492
 * Dislikes: 2622
 * Total Accepted:    3.9M
 * Total Submissions: 7.1M
 * Testcase Example:  '121'
 *
 * Given an integer x, return true if x is a palindrome, and false
 * otherwise.
 *
 *
 * Example 1:
 *
 *
 * Input: x = 121
 * Output: true
 * Explanation: 121 reads as 121 from left to right and from right to left.
 *
 *
 * Example 2:
 *
 *
 * Input: x = -121
 * Output: false
 * Explanation: From left to right, it reads -121. From right to left, it
 * becomes 121-. Therefore it is not a palindrome.
 *
 *
 * Example 3:
 *
 *
 * Input: x = 10
 * Output: false
 * Explanation: Reads 01 from right to left. Therefore it is not a
 * palindrome.
 *
 *
 *
 * Constraints:
 *
 *
 * -2^31 <= x <= 2^31 - 1
 *
 *
 *
 * Follow up: Could you solve it without converting the integer to a string?
 */

// @lc code=start
function isPalindrome(x: number): boolean {
  if (x < 0) return false;
  let reversedNumber = 0;
  let n = x;
  while (n !== 0) {
    reversedNumber = reversedNumber * 10 + (n % 10);
    n = Math.trunc(n / 10);
  }
  return reversedNumber === x;
}
// @lc code=end
