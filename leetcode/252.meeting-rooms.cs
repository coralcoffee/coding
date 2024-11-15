/*
 * @lc app=leetcode id=252 lang=csharp
 *
 * [252] Meeting Rooms
 *
 * https://leetcode.com/problems/meeting-rooms/description/
 *
 * algorithms
 * Easy (57.66%)
 * Likes:    2054
 * Dislikes: 105
 * Total Accepted:    431.8K
 * Total Submissions: 737.9K
 * Testcase Example:  '[[0,30],[5,10],[15,20]]'
 *
 * Given an array of meeting time intervals where intervals[i] = [starti,
 * endi], determine if a person could attend all meetings.
 * 
 * 
 * Example 1:
 * Input: intervals = [[0,30],[5,10],[15,20]]
 * Output: false
 * Example 2:
 * Input: intervals = [[7,10],[2,4]]
 * Output: true
 * 
 * 
 * Constraints:
 * 
 * 
 * 0 <= intervals.length <= 10^4
 * intervals[i].length == 2
 * 0 <= starti < endi <= 10^6
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public bool CanAttendMeetings(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < intervals[i - 1][1])
            {
                return false;
            }
        }

        return true;
    }
    public bool CanAttendMeetings1(int[][] intervals)
    {
        if (intervals.Length == 0) return true;
        for (int i = 1; i < intervals.Length; i++)
        {
            var cur = intervals[i];
            int j = i - 1;
            while (j >= 0 && intervals[j][0] >= cur[1])
            {
                intervals[j + 1] = intervals[j];
                j--;
            }
            if (j >= 0 && intervals[j][1] > cur[0]) return false;
            intervals[j + 1] = cur;
        }
        return true;
    }
}
// @lc code=end

