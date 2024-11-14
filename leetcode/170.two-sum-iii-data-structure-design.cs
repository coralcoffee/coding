/*
 * @lc app=leetcode id=170 lang=csharp
 *
 * [170] Two Sum III - Data structure design
 *
 * https://leetcode.com/problems/two-sum-iii-data-structure-design/description/
 *
 * algorithms
 * Easy (37.78%)
 * Likes:    679
 * Dislikes: 452
 * Total Accepted:    162.1K
 * Total Submissions: 422.1K
 * Testcase Example:  '["TwoSum","add","add","add","find","find"]\n[[],[1],[3],[5],[4],[7]]'
 *
 * Design a data structure that accepts a stream of integers and checks if it
 * has a pair of integers that sum up to a particular value.
 * 
 * Implement the TwoSum class:
 * 
 * 
 * TwoSum() Initializes the TwoSum object, with an empty array initially.
 * void add(int number) Adds number to the data structure.
 * boolean find(int value) Returns true if there exists any pair of numbers
 * whose sum is equal to value, otherwise, it returns false.
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input
 * ["TwoSum", "add", "add", "add", "find", "find"]
 * [[], [1], [3], [5], [4], [7]]
 * Output
 * [null, null, null, null, true, false]
 * 
 * Explanation
 * TwoSum twoSum = new TwoSum();
 * twoSum.add(1);   // [] --> [1]
 * twoSum.add(3);   // [1] --> [1,3]
 * twoSum.add(5);   // [1,3] --> [1,3,5]
 * twoSum.find(4);  // 1 + 3 = 4, return true
 * twoSum.find(7);  // No two integers sum up to 7, return false
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * -10^5 <= number <= 10^5
 * -2^31 <= value <= 2^31 - 1
 * At most 10^4 calls will be made to add and find.
 * 
 * 
 */

// @lc code=start
public class TwoSum
{
    Dictionary<int, int> counts;
    public TwoSum()
    {
        counts = new Dictionary<int, int>();
    }

    public void Add(int number)
    {
        if (counts.ContainsKey(number))
        {
            counts[number]++;
        }
        else
        {
            counts.Add(number, 1);
        }
    }

    public bool Find(int value)
    {
        foreach (var pair in counts)
        {
            int sub = value - pair.Key;
            if (counts.ContainsKey(sub))
            {
                if (pair.Key != sub || pair.Value > 1)
                    return true;
            }
        }
        return false;
    }
}

/**
 * Your TwoSum object will be instantiated and called as such:
 * TwoSum obj = new TwoSum();
 * obj.Add(number);
 * bool param_2 = obj.Find(value);
 */
// @lc code=end

