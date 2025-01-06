using NUnit.Framework;
using Sample.BackTracking;
using Shouldly;
using System.Diagnostics;

namespace Sample.Tests.BackTracking
{
    public class PermutationsTests
    {
        [Test]
        public void PermutationI_MultipleElementsArray_ReturnsAllPermutations()
        {
            // Arrange
            var permutations = new Permutations();
            var nums = new[] { 1, 2, 3 };

            // Act
            var result = permutations.PermutationI(nums);

            // Assert
            var expected = new List<IList<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 1, 3, 2 },
                new List<int> { 2, 1, 3 },
                new List<int> { 2, 3, 1 },
                new List<int> { 3, 1, 2 },
                new List<int> { 3, 2, 1 }
            };

            expected.Count.ShouldBeEquivalentTo(result.Count);
            foreach (var permutation in expected)
            {
                TestContext.WriteLine(string.Join(" ", permutation));
                //permutation.ShouldBeEquivalentTo(result);
            }
        }
    }
}
