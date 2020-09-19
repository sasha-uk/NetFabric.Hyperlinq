using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace NetFabric.Hyperlinq.SourceGenerator.UnitTests
{
    public partial class GeneratorTests
    {
        static readonly string[] commonPaths = new string[]
        {
            "TestData/Source/Common/INullableSelector.cs",
            "TestData/Source/Common/IPredicate.cs",
            "TestData/Source/Common/IValueEnumerable.cs",
            "TestData/Source/Common/NullableSelector.cs",
            "TestData/Source/Common/NullableSelectorNullableSelectorCombination.cs",
            "TestData/Source/Common/PredicatePredicateCombination.cs",
            "TestData/Source/Common/ValueNullableSelectorWrapper.cs",
            "TestData/Source/Common/ValuePredicateWrapper.cs",
        };

        public static TheoryData<string[]> Empty 
            => new TheoryData<string[]> { 
                new string[] {
                    "TestData/Source/Count.ValueEnumerable.cs",
                    "TestData/Source/Where.ArraySegment.cs",
                },
            };

        [Theory]
        [MemberData(nameof(Empty))]
        public async Task ClassesWithOverloadsShouldNotGenerate(string[] paths)
        {
            // Arrange
            var project = Verifier.CreateProject(
                paths
                .Concat(commonPaths)
                .Select(path => File.ReadAllText(path)));
            var compilation = await project.GetCompilationAsync();

            // Act
            var generator = new OverloadsGenerator();
            var extensionMethods = generator.CollectExtensionMethods(compilation!);
            var result = generator.GenerateSource(compilation!, extensionMethods);

            // Assert
            Assert.Empty(result);
        }
    }
}