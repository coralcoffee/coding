public class Sample
{
    int BinarySearch(int[] nums, int target)
    {
        int i = 0, j = nums.Length - 1;
        while (i <= j)
        {
            int m = i + (j - i) / 2;
            if (nums[m] < target)
                i = m + 1;
            else if (nums[m] > target)
                j = m - 1;
            else
                return m;
        }
        return -1;
    }
}
public class MovingAverage
{
    int size = 0;
    private Queue<int> queue = new Queue<int>();
    public MovingAverage(int size)
    {
        this.size = size;
    }

    public double Next(int val)
    {
        if (queue.Count >= size)
        {
            queque.Dequeue();
        }
        queue.Enqueue(val);
        int total = 0;
        foreach (int n in queue)
        {
            total += n;
        }
        return total / queue.Count;
    }
}