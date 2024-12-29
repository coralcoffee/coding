namespace Sample.Searching;

public class Searching
{
    public int[] TwoSumBruteForce(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
                if (nums[i] + nums[j] == target)
                    return [i, j];
        }
        return [];
    }
    public int[] TwoSumHashTable(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int sub = target - nums[i];
            if (map.ContainsKey(sub))
            {
                return [map[sub], i];
            }
            map[nums[i]] = i;
        }
        return [];
    }
}
