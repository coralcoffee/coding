namespace Sample.Backtracking;

public class Traversal
{
    private void Backtrack(TreeNode? root, List<TreeNode> res)
    {
        if (root == null)
        {
            return;
        }
        if (root.Value == 7)
        {
            res.Add(root);
        }
        Backtrack(root.Left, res);
        Backtrack(root.Right, res);
    }
}
