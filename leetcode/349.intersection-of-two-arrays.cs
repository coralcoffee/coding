/*
 * @lc app=leetcode id=349 lang=csharp
 *
 * [349] Intersection of Two Arrays
 *
 * https://leetcode.com/problems/intersection-of-two-arrays/description/
 *
 * algorithms
 * Easy (71.84%)
 * Likes:    6218
 * Dislikes: 2302
 * Total Accepted:    1.4M
 * Total Submissions: 1.8M
 * Testcase Example:  '[1,2,2,1]\n[2,2]'
 *
 * Given two integer arrays nums1 and nums2, return an array of their
 * intersection. Each element in the result must be unique and you may return
 * the result in any order.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums1 = [1,2,2,1], nums2 = [2,2]
 * Output: [2]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
 * Output: [9,4]
 * Explanation: [4,9] is also accepted.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums1.length, nums2.length <= 1000
 * 0 <= nums1[i], nums2[i] <= 1000
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();
        HashSet<int> n1 = new HashSet<int>();
        HashSet<int> n2 = new HashSet<int>();
        foreach (var n in nums1)
        {
            n1.Add(n);
        }
        foreach (var n in nums2)
        {
            if (n1.Contains(n) && !n2.Contains(n))
            {
                result.Add(n);
                n2.Add(n);
            }
        }
        return result.ToArray();
    }
}
// @lc code=end

