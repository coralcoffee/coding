// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] nums = { 1, 2, 3, 4, 5 };
var permutations = GetPermutations(nums, nums.Length);

foreach (var perm in permutations)
{
    foreach (var num in perm)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

List<List<int>> GetPermutations(int[] nums, int length)
{
    var result = new List<List<int>>();
    Permute(nums, 0, length - 1, result);
    return result;
}

void Permute(int[] array, int start, int end, List<List<int>> result)
{
    if (start == end)
    {
        result.Add(new List<int>(array));
    }
    else
    {
        for (int i = start; i <= end; i++)
        {
            Swap(ref array[start], ref array[i]);
            Permute(array, start + 1, end, result);
            Swap(ref array[start], ref array[i]); // backtrack
        }
    }
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}