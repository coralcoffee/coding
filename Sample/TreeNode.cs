namespace Sample;

public class TreeNode
{
    public int Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }

    public TreeNode(int value)
    {
        Value = value;
    }

    private static TreeNode? ListToTreeDFS(IList<int?> arr, int i)
    {
        if (i < 0 || i >= arr.Count() || !arr[i].HasValue)
            return null;
        var node = new TreeNode(arr[i]!.Value)
        {
            Left = ListToTreeDFS(arr, i * 2 + 1),
            Right = ListToTreeDFS(arr, i * 2 + 2)
        };
        return node;
    }

    public static TreeNode? ListToTreeDFS(IList<int?> arr)
    {
        return ListToTreeDFS(arr, 0);
    }
}
