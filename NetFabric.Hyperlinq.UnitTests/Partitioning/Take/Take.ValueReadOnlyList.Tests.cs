using System;
using System.Collections.Generic;
using System.Diagnostics;
using FluentAssertions;
using Xunit;

namespace NetFabric.Hyperlinq.UnitTests
{
    public class TakeValueReadOnlyListTests
    {
        [Theory]
        [MemberData(nameof(TestData.Take), MemberType = typeof(TestData))]
        public void Take_With_ValidData_Should_Succeed(int[] source, int count, int[] expected)
        {
            // Arrange
            var list = Wrap.AsValueReadOnlyList(source);

            // Act
            var result = ValueReadOnlyList.Take<Wrap.ValueReadOnlyList<int>, Wrap.ValueReadOnlyList<int>.Enumerator, int>(list, count);

            // Assert
            result.Should().Generate(expected);
        }
    }
}