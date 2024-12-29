using NUnit.Framework;
using Shouldly;

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
        res.Count().ShouldBe(2);
        res[0].ShouldBe(0);
        res[1].ShouldBe(2);

    }

    [Test]
    public void Two_Sum_With_Hash_Test()
    {
        Searching searching = new Searching();
        int[] nums = [2, 7, 11, 15];
        int target = 13;
        int[] res = searching.TwoSumHashTable(nums, target);
        res.Count().ShouldBe(2);
        res[0].ShouldBe(0);
        res[1].ShouldBe(2);
    }
}