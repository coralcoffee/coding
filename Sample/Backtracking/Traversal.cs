namespace Sample.Backtracking;

public class Traversal
{
    private void Backtrack(BinaryTreeNode? root, List<BinaryTreeNode> res)
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
