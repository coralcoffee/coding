﻿using NUnit.Framework;
using Sample.Backtracking;
using Shouldly;

namespace SubsetSumTests
{
    [TestFixture]
    public class SubsetSumTests
    {

        [Test]
        public void SubsetSumI_SingleSubset_ReturnsCorrectSubset()
        {
            // Arrange
            var nums = new int[] { 1, 2, 3 };
            var target = 3;
            var c = new SubsetSum();
            // Act
            var result = c.SubsetSumI(nums, target);

            // Assert
            result.ShouldContain(new List<int> { 3 });
        }

        [Test]
        public void SubsetSumI_MultipleSubsets_ReturnsAllSubsets()
        {
            // Arrange
            var nums = new int[] { 3, 4, 5 };
            var target = 9;

            var c = new SubsetSum();
            // Act
            var result = c.SubsetSumI(nums, target);

            // Assert
            result.ShouldContain(new List<int> { 1, 2 });
            result.ShouldContain(new List<int> { 3 });
        }

        [Test]
        public void SubsetSumI_EmptyArray_ReturnsEmptyList()
        {
            // Arrange
            var nums = new int[] { };
            var target = 0;
            var c = new SubsetSum();
            // Act
            var result = c.SubsetSumI(nums, target);

            // Assert
            result.ShouldBeEmpty();
        }

        [Test]
        public void SubsetSumI_TargetZero_ReturnsEmptySubset()
        {
            // Arrange
            var nums = new int[] { 1, 2, 3 };
            var target = 0;
            var c = new SubsetSum();
            // Act
            var result = c.SubsetSumI(nums, target);

            // Assert
            result.ShouldContain(new List<int>());
        }
    }
}
