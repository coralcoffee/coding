/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 *
 * https://leetcode.com/problems/median-of-two-sorted-arrays/description/
 *
 * algorithms
 * Hard (38.34%)
 * Likes:    26683
 * Dislikes: 2937
 * Total Accepted:    2.2M
 * Total Submissions: 5.8M
 * Testcase Example:  '[1,3]\n[2]'
 *
 * Given two sorted arrays nums1 and nums2 of size m and n respectively, return
 * the median of the two sorted arrays.
 * 
 * The overall run time complexity should be O(log (m+n)).
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums1 = [1,3], nums2 = [2]
 * Output: 2.00000
 * Explanation: merged array = [1,2,3] and median is 2.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums1 = [1,2], nums2 = [3,4]
 * Output: 2.50000
 * Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * nums1.length == m
 * nums2.length == n
 * 0 <= m <= 1000
 * 0 <= n <= 1000
 * 1 <= m + n <= 2000
 * -10^6 <= nums1[i], nums2[i] <= 10^6
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int FindKthElement(int k)
        {
            int index1 = 0, index2 = 0;

            while (true)
            {
                if (index1 == nums1.Length)
                    return nums2[index2 + k - 1];
                if (index2 == nums2.Length)
                    return nums1[index1 + k - 1];

                if (k == 1)
                    return Math.Min(nums1[index1], nums2[index2]);

                int newIndex1 = Math.Min(index1 + k / 2 - 1, nums1.Length - 1);
                int newIndex2 = Math.Min(index2 + k / 2 - 1, nums2.Length - 1);
                int pivot1 = nums1[newIndex1], pivot2 = nums2[newIndex2];

                if (pivot1 <= pivot2)
                {
                    k -= (newIndex1 - index1 + 1);
                    index1 = newIndex1 + 1;
                }
                else
                {
                    k -= (newIndex2 - index2 + 1);
                    index2 = newIndex2 + 1;
                }
            }
        }

        int totalLength = nums1.Length + nums2.Length;
        if (totalLength % 2 == 1)
        {
            return FindKthElement(totalLength / 2 + 1);
        }
        else
        {
            return (FindKthElement(totalLength / 2) + FindKthElement(totalLength / 2 + 1)) / 2.0;
        }
    }
}
// @lc code=end

