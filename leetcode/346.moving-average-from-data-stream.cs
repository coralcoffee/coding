/*
 * @lc app=leetcode id=346 lang=csharp
 *
 * [346] Moving Average from Data Stream
 *
 * https://leetcode.com/problems/moving-average-from-data-stream/description/
 *
 * algorithms
 * Easy (77.39%)
 * Likes:    1684
 * Dislikes: 180
 * Total Accepted:    430K
 * Total Submissions: 543.3K
 * Testcase Example:  '["MovingAverage","next","next","next","next"]\n[[3],[1],[10],[3],[5]]'
 *
 * Given a stream of integers and a window size, calculate the moving average
 * of all integers in the sliding window.
 * 
 * Implement the MovingAverage class:
 * 
 * 
 * MovingAverage(int size) Initializes the object with the size of the window
 * size.
 * double next(int val) Returns the moving average of the last size values of
 * the stream.
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input
 * ["MovingAverage", "next", "next", "next", "next"]
 * [[3], [1], [10], [3], [5]]
 * Output
 * [null, 1.0, 5.5, 4.66667, 6.0]
 * 
 * Explanation
 * MovingAverage movingAverage = new MovingAverage(3);
 * movingAverage.next(1); // return 1.0 = 1 / 1
 * movingAverage.next(10); // return 5.5 = (1 + 10) / 2
 * movingAverage.next(3); // return 4.66667 = (1 + 10 + 3) / 3
 * movingAverage.next(5); // return 6.0 = (10 + 3 + 5) / 3
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= size <= 1000
 * -10^5 <= val <= 10^5
 * At most 10^4 calls will be made to next.
 * 
 * 
 */

// @lc code=start
public class MovingAverage
{
    private int size = 0;
    private Queue<int> queue = new Queue<int>();
    private double sum = 0;
    public MovingAverage(int size)
    {
        this.size = size;
    }

    public double Next(int val)
    {
        if (queue.Count >= size)
        {
            sum -= queue.Dequeue();
        }
        queue.Enqueue(val);
        sum += val;
        return sum / queue.Count;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */
// @lc code=end

