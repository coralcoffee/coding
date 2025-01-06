// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string s = "code";

int b = 0;

foreach (char c in s)
{
    b = b ^ c;
}
Console.WriteLine(b);
Console.WriteLine(1 << ('a' - 'a'));
return;

int[] nums = { 1, 2, 3, 4 };
var permutations = new List<List<int>>();
Permute(nums, 0, nums.Length - 1, permutations);

int permutation = 0;
foreach (var perm in permutations)
{
    foreach (var num in perm)
    {
        Console.Write(num + " ");
    }
    permutation++;
    Console.WriteLine();
}
Console.WriteLine($"Permutation is: {permutation}");

void Permute<T>(T[] array, int start, int end, List<List<T>> result)
{
    if (start == end)
    {
        result.Add(array.ToList()); // Using ToList() to create a copy for storing in the result list
        return;
    }

    HashSet<T> swappedElements = new HashSet<T>();

    for (int i = start; i <= end; i++)
    {
        // Skip duplicates if we have already seen this element at this level
        if (swappedElements.Contains(array[i]))
        {
            continue;
        }

        swappedElements.Add(array[i]);

        // Only swap if necessary to avoid redundant swaps
        if (start != i)
        {
            (array[start], array[i]) = (array[i], array[start]);
        }

        Permute(array, start + 1, end, result);

        // Backtrack
        if (start != i)
        {
            (array[start], array[i]) = (array[i], array[start]);
        }
    }
}

//public int SumOfLeftLeaves(TreeNode root)
//{
//    int result = 0;
//    SumOfLeftLeaves(root, ref result);

//    return result;
//}

//private int SumOfLeftLeaves(TreeNode root, ref int result)
//{

//    if (root == null) return 0;
//    if (root.left == null && root.right == null) return root.val;

//    result += SumOfLeftLeaves(root.left, ref result);

//    SumOfLeftLeaves(root.right, ref result);
//}