/*
 * @lc app=leetcode id=345 lang=csharp
 *
 * [345] Reverse Vowels of a String
 *
 * https://leetcode.com/problems/reverse-vowels-of-a-string/description/
 *
 * algorithms
 * Easy (51.61%)
 * Likes:    4723
 * Dislikes: 2811
 * Total Accepted:    1.1M
 * Total Submissions: 1.9M
 * Testcase Example:  '"IceCreAm"'
 *
 * Given a string s, reverse only all the vowels in the string and return it.
 * 
 * The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both
 * lower and upper cases, more than once.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: s = "IceCreAm"
 * 
 * Output: "AceCreIm"
 * 
 * Explanation:
 * 
 * The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes
 * "AceCreIm".
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "leetcode"
 * 
 * Output: "leotcede"
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= s.length <= 3 * 10^5
 * s consist of printable ASCII characters.
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public string ReverseVowels(string s)
    {
        char[] array = new char[s.Length];
        int left = 0, right = s.Length - 1;
        bool found = false;
        while (left <= right)
        {
            if (found)
            {
                if (IsVowel(s[right]))
                {
                    array[left] = s[right];
                    array[right] = s[left];
                    found = false;
                    left++;
                    right--;
                }
                else
                {
                    array[right] = s[right];
                    right--;
                }
            }
            else
            {
                if (IsVowel(s[left]))
                {
                    found = true;
                }
                else
                {
                    array[left] = s[left];
                    left++;
                }
            }
        }
        return new string(array);
    }

    private bool IsVowel(char c)
    {
        return c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'
            || c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
// @lc code=end

