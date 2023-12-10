#
# @lc app=leetcode id=5 lang=python3
#
# [5] Longest Palindromic Substring
#
# https://leetcode.com/problems/longest-palindromic-substring/description/
#
# algorithms
# Medium (33.25%)
# Likes:    28008
# Dislikes: 1660
# Total Accepted:    2.7M
# Total Submissions: 8.3M
# Testcase Example:  '"babad"'
#
# Given a string s, return the longest palindromic substring in s.
#
#
# Example 1:
#
#
# Input: s = "babad"
# Output: "bab"
# Explanation: "aba" is also a valid answer.
#
#
# Example 2:
#
#
# Input: s = "cbbd"
# Output: "bb"
#
#
#
# Constraints:
#
#
# 1 <= s.length <= 1000
# s consist of only digits and English letters.
#
#
#

# @lc code=start
class Solution:
    def longestPalindrome(self, s: str) -> str:
        startIndex = 0
        maxLength = 0
        for i in range(len(s)):
            start = i
            end = i
            while end < len(s)-1 and s[start] == s[end+1]:
                end += 1
            while start > 0 and end < len(s)-1 and s[start-1] == s[end+1]:
                start -= 1
                end += 1

            if maxLength < end - start + 1:
                maxLength = end - start + 1
                startIndex = start

        return s[startIndex:startIndex+maxLength]
# @lc code=end
