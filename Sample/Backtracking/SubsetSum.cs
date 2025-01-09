namespace Sample.Backtracking;

public class SubsetSum
{
    private void Backtrack(List<int> state, int target, int total, int[] choices, List<List<int>> res)
    {
        if (total == target)
        {
            res.Add(new List<int>(state));
            return;
        }

        for (int i = 0; i < choices.Length; i++)
        {
            if (total + choices[i] > target) break;
            state.Add(choices[i]);
            Backtrack(state, target, total + choices[i], choices, res);
            state.RemoveAt(state.Count - 1);
        }
    }

    public List<List<int>> SubsetSumI(int[] nums, int target)
    {
        List<List<int>> res = [];
        Backtrack([], target, 0, nums, res);
        return res;
    }
}
