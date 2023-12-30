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
        if (nums1.Length > nums2.Length) return FindMedianSortedArrays(nums2, nums1);

        int m = nums1.Length;
        int n = nums2.Length;

        if (m == 0)
            return n % 2 == 0 ? (nums2[n / 2 - 1] + nums2[n / 2]) / 2.0 : nums2[n / 2];

        int low = 0, high = m, halfLen = (m + n + 1) / 2;

        while (low <= high)
        {
            int partitionX = (low + high) / 2;
            int partitionY = halfLen - partitionX;

            if (partitionX < m && nums2[partitionY - 1] > nums1[partitionX])
            {
                low = partitionX + 1;
            }
            else if (partitionX > 0 && nums1[partitionX - 1] > nums2[partitionY])
            {
                high = partitionX - 1;
            }
            else
            {
                int maxLeft = Math.Max(partitionX == 0 ? Int32.MinValue : nums1[partitionX - 1],
                                       partitionY == 0 ? Int32.MinValue : nums2[partitionY - 1]);

                if ((m + n) % 2 == 1)
                    return maxLeft;

                int minRight = Math.Min(partitionX == m ? Int32.MaxValue : nums1[partitionX],
                                        partitionY == n ? Int32.MaxValue : nums2[partitionY]);

                return (maxLeft + minRight) / 2.0;
            }
        }
        return 0;
    }
}
// @lc code=end

