using NUnit.Framework;

namespace Sample.Searching;

public class SearchingTests
{
    [Test]
    public void Two_Sum_Test()
    {
        Searching searching = new Searching();
        int[] nums = [2, 7, 11, 15];
        int target = 13;
        int[] res = searching.TwoSumBruteForce(nums, target);
        Console.WriteLine("TwoSumBruteForce res = " + string.Join(",", res));
    }
}
