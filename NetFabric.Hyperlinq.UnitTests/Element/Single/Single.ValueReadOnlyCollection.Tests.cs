using NetFabric.Assertive;
using System;
using System.Linq;
using Xunit;

namespace NetFabric.Hyperlinq.UnitTests.Element.Single
{
    public class ValueReadOnlyCollectionTests
    {
        [Theory]
        [MemberData(nameof(TestData.Empty), MemberType = typeof(TestData))]
        public void Single_With_Empty_Must_Return_None(int[] source)
        {
            // Arrange
            var wrapped = Wrap
                .AsValueReadOnlyCollection(source);

            // Act
            var result = ValueReadOnlyCollectionExtensions
                .Single<Wrap.ValueReadOnlyCollectionWrapper<int>, Wrap.Enumerator<int>, int>(wrapped);

            // Assert
            _ = result.Must()
                .BeOfType<Option<int>>()
                .EvaluateTrue(option => option.IsNone);
        }

        [Theory]
        [MemberData(nameof(TestData.Single), MemberType = typeof(TestData))]
        public void Single_With_Single_Must_Return_Some(int[] source)
        {
            // Arrange
            var wrapped = Wrap
                .AsValueReadOnlyCollection(source);
            var expected = Enumerable
                .Single(source);

            // Act
            var result = ValueReadOnlyCollectionExtensions
                .Single<Wrap.ValueReadOnlyCollectionWrapper<int>, Wrap.Enumerator<int>, int>(wrapped);

            // Assert
            _ = result.Match(
                value => value.Must().BeEqualTo(expected), 
                () => throw new Exception());
        }

        [Theory]
        [MemberData(nameof(TestData.Multiple), MemberType = typeof(TestData))]
        public void Single_With_Multiple_Must_Return_None(int[] source)
        {
            // Arrange
            var wrapped = Wrap
                .AsValueReadOnlyCollection(source);

            // Act
            var result = ValueReadOnlyCollectionExtensions
                .Single<Wrap.ValueReadOnlyCollectionWrapper<int>, Wrap.Enumerator<int>, int>(wrapped);

            // Assert
            _ = result.Must()
                .BeOfType<Option<int>>()
                .EvaluateTrue(option => option.IsNone);
        }

        [Theory]
        [MemberData(nameof(TestData.SelectorEmpty), MemberType = typeof(TestData))]
        public void Single_Selector_With_Empty_Must_Return_None(int[] source, NullableSelector<int, string> selector)
        {
            // Arrange
            var wrapped = Wrap
                .AsValueReadOnlyCollection(source);

            // Act
            var result = ValueReadOnlyCollectionExtensions
                .Select<Wrap.ValueReadOnlyCollectionWrapper<int>, Wrap.Enumerator<int>, int, string>(wrapped, selector)
                .Single();

            // Assert
            _ = result.Must()
                .BeOfType<Option<string>>()
                .EvaluateTrue(option => option.IsNone);
        }

        [Theory]
        [MemberData(nameof(TestData.SelectorSingle), MemberType = typeof(TestData))]
        public void Single_Selector_With_Single_Must_Return_Some(int[] source, NullableSelector<int, string> selector)
        {
            // Arrange
            var wrapped = Wrap
                .AsValueReadOnlyCollection(source);
            var expected = Enumerable
                .Select(source, selector.AsFunc())
                .Single();

            // Act
            var result = ValueReadOnlyCollectionExtensions
                .Select<Wrap.ValueReadOnlyCollectionWrapper<int>, Wrap.Enumerator<int>, int, string>(wrapped, selector)
                .Single();

            // Assert
            _ = result.Match(
                value => value.Must().BeEqualTo(expected), 
                () => throw new Exception());
        }

        [Theory]
        [MemberData(nameof(TestData.SelectorMultiple), MemberType = typeof(TestData))]
        public void Single_Selector_With_Multiple_Must_Return_None(int[] source, NullableSelector<int, string> selector)
        {
            // Arrange
            var wrapped = Wrap
                .AsValueReadOnlyCollection(source);

            // Act
            var result = ValueReadOnlyCollectionExtensions
                .Select<Wrap.ValueReadOnlyCollectionWrapper<int>, Wrap.Enumerator<int>, int, string>(wrapped, selector)
                .Single();

            // Assert
            _ = result.Must()
                .BeOfType<Option<string>>()
                .EvaluateTrue(option => option.IsNone);
        }

        [Theory]
        [MemberData(nameof(TestData.SelectorAtEmpty), MemberType = typeof(TestData))]
        public void Single_SelectorAt_With_Empty_Must_Return_None(int[] source, NullableSelectorAt<int, string> selector)
        {
            // Arrange
            var wrapped = Wrap
                .AsValueReadOnlyCollection(source);

            // Act
            var result = ValueReadOnlyCollectionExtensions
                .Select<Wrap.ValueReadOnlyCollectionWrapper<int>, Wrap.Enumerator<int>, int, string>(wrapped, selector)
                .Single();

            // Assert
            _ = result.Must()
                .BeOfType<Option<string>>()
                .EvaluateTrue(option => option.IsNone);
        }

        [Theory]
        [MemberData(nameof(TestData.SelectorAtSingle), MemberType = typeof(TestData))]
        public void Single_SelectorAt_With_Single_Must_Return_Some(int[] source, NullableSelectorAt<int, string> selector)
        {
            // Arrange
            var wrapped = Wrap
                .AsValueReadOnlyCollection(source);
            var expected = Enumerable
                .Select(source, selector.AsFunc())
                .Single();

            // Act
            var result = ValueReadOnlyCollectionExtensions
                .Select<Wrap.ValueReadOnlyCollectionWrapper<int>, Wrap.Enumerator<int>, int, string>(wrapped, selector)
                .Single();

            // Assert
            _ = result.Match(
                value => value.Must().BeEqualTo(expected), 
                () => throw new Exception());
        }

        [Theory]
        [MemberData(nameof(TestData.SelectorAtMultiple), MemberType = typeof(TestData))]
        public void Single_SelectorAt_With_Multiple_Must_Return_None(int[] source, NullableSelectorAt<int, string> selector)
        {
            // Arrange
            var wrapped = Wrap
                .AsValueReadOnlyCollection(source);

            // Act
            var result = ValueReadOnlyCollectionExtensions
                .Select<Wrap.ValueReadOnlyCollectionWrapper<int>, Wrap.Enumerator<int>, int, string>(wrapped, selector)
                .Single();

            // Assert
            _ = result.Must()
                .BeOfType<Option<string>>()
                .EvaluateTrue(option => option.IsNone);
        }
    }
}