/*
 * @lc app=leetcode id=350 lang=csharp
 *
 * [350] Intersection of Two Arrays II
 *
 * https://leetcode.com/problems/intersection-of-two-arrays-ii/description/
 *
 * algorithms
 * Easy (56.23%)
 * Likes:    7768
 * Dislikes: 982
 * Total Accepted:    1.5M
 * Total Submissions: 2.5M
 * Testcase Example:  '[1,2,2,1]\n[2,2]'
 *
 * Given two integer arrays nums1 and nums2, return an array of their
 * intersection. Each element in the result must appear as many times as it
 * shows in both arrays and you may return the result in any order.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums1 = [1,2,2,1], nums2 = [2,2]
 * Output: [2,2]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
 * Output: [4,9]
 * Explanation: [9,4] is also accepted.
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
 * 
 * Follow up:
 * 
 * 
 * What if the given array is already sorted? How would you optimize your
 * algorithm?
 * What if nums1's size is small compared to nums2's size? Which algorithm is
 * better?
 * What if elements of nums2 are stored on disk, and the memory is limited such
 * that you cannot load all elements into the memory at once?
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();
        Dictionary<int, int> dict1 = new Dictionary<int, int>();
        foreach (var n in nums1)
        {
            if (dict1.TryGetValue(n, out int count))
            {
                dict1[n] = count + 1;
            }
            else
            {
                dict1.Add(n, 1);
            }
        }
        foreach (var n in nums2)
        {
            if (dict1.TryGetValue(n, out int count) && count > 0)
            {
                result.Add(n);
                dict1[n]--;
            }
        }
        return result.ToArray();
    }
}
// @lc code=end

