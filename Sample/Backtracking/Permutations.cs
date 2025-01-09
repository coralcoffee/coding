namespace Sample.BackTracking;

public class Permutations
{
    private void Backtrack(List<int> state, int[] choices, bool[] selected, List<List<int>> res)
    {
        if (state.Count == choices.Length)
        {
            res.Add(new List<int>(state));
            return;
        }
        for (int i = 0; i < choices.Length; i++)
        {
            if (selected[i]) continue;
            selected[i] = true;
            state.Add(choices[i]);
            Backtrack(state, choices, selected, res);
            selected[i] = false;
            state.RemoveAt(state.Count - 1);
        }
    }
    public List<List<int>> PermutationI(int[] nums)
    {
        var res = new List<List<int>>();
        Backtrack([], nums, new bool[nums.Length], res);
        return res;
    }

    private void BacktrackII(List<int> state, int[] nums, bool[] selected, List<List<int>> res)
    {
        if (state.Count == nums.Length)
        {
            res.Add(new List<int>(state));
            return;
        }
        HashSet<int> used = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (selected[i] || used.Contains(nums[i])) continue;
            used.Add(nums[i]);
            selected[i] = true;
            state.Add(nums[i]);
            BacktrackII(state, nums, selected, res);
            state.RemoveAt(state.Count - 1);
            selected[i] = false;
        }
    }

    public List<List<int>> PermutationII(int[] nums)
    {
        var res = new List<List<int>>();
        BacktrackII([], nums, new bool[nums.Length], res);
        return res;
    }
}
