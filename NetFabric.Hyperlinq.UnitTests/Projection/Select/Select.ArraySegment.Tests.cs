using NetFabric.Assertive;
using System;
using System.Linq;
using Xunit;

namespace NetFabric.Hyperlinq.UnitTests.Projection.Select
{
    public class ArraySegmentTests
    {
        [Fact]
        public void Select_With_NullSelector_Must_Throw()
        {
            // Arrange
            var source = new int[0];
            var wrapped = new ArraySegment<int>(source);
            var selector = (NullableSelector<int, string>)null;

            // Act
            Action action = () => _ = ArrayExtensions
                .Select(wrapped, selector);

            // Assert
            _ = action.Must()
                .Throw<ArgumentNullException>()
                .EvaluateTrue(exception => exception.ParamName == "selector");
        }

        [Fact]
        public void Select_With_NullArray_Must_Succeed()
        {
            // Arrange
            var source = default(ArraySegment<int>);
            var expected = Enumerable.Empty<int>();

            // Act
            var result = ArrayExtensions
                .Select(source, item => item);

            // Assert
            _ = result.Must()
                .BeEnumerableOf<int>()
                .BeEqualTo(expected);
        }

        [Theory]
        [MemberData(nameof(TestData.SkipTakeSelectorEmpty), MemberType = typeof(TestData))]
        [MemberData(nameof(TestData.SkipTakeSelectorSingle), MemberType = typeof(TestData))]
        [MemberData(nameof(TestData.SkipTakeSelectorMultiple), MemberType = typeof(TestData))]
        public void Select_With_ValidData_Must_Succeed(int[] source, int skip, int take, NullableSelector<int, string> selector)
        {
            // Arrange
            var (offset, count) = Utils.SkipTake(source.Length, skip, take);
            var wrapped = new ArraySegment<int>(source, offset, count);
            var expected = Enumerable
                .Select(wrapped, selector.AsFunc());

            // Act
            var result = ArrayExtensions
                .Select(wrapped, selector);

            // Assert
            _ = result.Must()
                .BeEnumerableOf<string>()
                .BeEqualTo(expected, testRefStructs: false);
            _ = result.SequenceEqual(expected).Must().BeTrue();
        }
    }
}