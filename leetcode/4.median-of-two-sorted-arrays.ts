/*
 * @lc app=leetcode id=4 lang=typescript
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
function findMedianSortedArrays(nums1: number[], nums2: number[]): number {
  if (nums1.length > nums2.length) return findMedianSortedArrays(nums2, nums1);
  const m = nums1.length;
  const n = nums2.length;

  let low = 0,
    high = m;

  while (low <= high) {
    let poistionX = Math.floor((low + high) / 2);
    let positionY = Math.floor((m + n + 1) / 2) - poistionX;

    let leftX = poistionX === 0 ? -Infinity : nums1[poistionX - 1];
    let leftY = positionY === 0 ? -Infinity : nums2[positionY - 1];

    let rightX = poistionX === m ? Infinity : nums1[poistionX];
    let rightY = positionY === n ? Infinity : nums2[positionY];

    if (leftX <= rightY && leftY <= rightX) {
      if ((m + n) % 2 === 0) {
        return (Math.max(leftX, leftY) + Math.min(rightX, rightY)) / 2;
      } else {
        return Math.max(leftX, leftY);
      }
    } else if (leftX > rightY) {
      high = poistionX - 1;
    } else {
      low = poistionX + 1;
    }
  }

  return 0;
}
// @lc code=end
