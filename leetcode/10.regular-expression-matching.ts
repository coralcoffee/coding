/*
 * @lc app=leetcode id=10 lang=typescript
 *
 * [10] Regular Expression Matching
 *
 * https://leetcode.com/problems/regular-expression-matching/description/
 *
 * algorithms
 * Hard (27.86%)
 * Likes:    11564
 * Dislikes: 1960
 * Total Accepted:    876.2K
 * Total Submissions: 3.1M
 * Testcase Example:  '"aa"\n"a"'
 *
 * Given an input string s and a pattern p, implement regular expression
 * matching with support for '.' and '*' where:
 *
 *
 * '.' Matches any single character.​​​​
 * '*' Matches zero or more of the preceding element.
 *
 *
 * The matching should cover the entire input string (not partial).
 *
 *
 * Example 1:
 *
 *
 * Input: s = "aa", p = "a"
 * Output: false
 * Explanation: "a" does not match the entire string "aa".
 *
 *
 * Example 2:
 *
 *
 * Input: s = "aa", p = "a*"
 * Output: true
 * Explanation: '*' means zero or more of the preceding element, 'a'.
 * Therefore, by repeating 'a' once, it becomes "aa".
 *
 *
 * Example 3:
 *
 *
 * Input: s = "ab", p = ".*"
 * Output: true
 * Explanation: ".*" means "zero or more (*) of any character (.)".
 *
 *
 *
 * Constraints:
 *
 *
 * 1 <= s.length <= 20
 * 1 <= p.length <= 20
 * s contains only lowercase English letters.
 * p contains only lowercase English letters, '.', and '*'.
 * It is guaranteed for each appearance of the character '*', there will be a
 * previous valid character to match.
 *
 *
 */

// @lc code=start
function isMatch(s: string, p: string): boolean {
  let indexS = 0;
  let indexP = 0;
  while (indexS < s.length) {
    if (indexP >= p.length) return false;
    if (s[indexS] === p[indexP] || p[indexP] === ".") {
      indexS++;
      if (p[indexP + 1] !== "*") indexP++;
      continue;
    } else if (p[indexP + 1] === "*") {
      indexP += 2;
      continue;
    }
    return false;
  }
  if (indexP < p.length - 1 && p[indexP + 1] === "*") indexP += 2;
  ''
  return true;
}
// @lc code=end
