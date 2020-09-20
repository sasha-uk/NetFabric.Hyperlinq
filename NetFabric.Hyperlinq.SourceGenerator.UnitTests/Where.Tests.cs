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
            "TestData/Source/Common/GeneratorIgnoreAttribute.cs",
            "TestData/Source/Common/GeneratorMappingAttribute.cs",
            "TestData/Source/Common/INullableSelector.cs",
            "TestData/Source/Common/IPredicate.cs",
            "TestData/Source/Common/IValueEnumerable.cs",
            "TestData/Source/Common/NullableSelector.cs",
            "TestData/Source/Common/NullableSelectorNullableSelectorCombination.cs",
            "TestData/Source/Common/PredicatePredicateCombination.cs",
            "TestData/Source/Common/ValueNullableSelectorWrapper.cs",
            "TestData/Source/Common/ValuePredicateWrapper.cs",
        };

        public static TheoryData<string[], int> ExtensionMethods
            => new TheoryData<string[], int> {
                { new string[] { "TestData/Source/NoExtensionMethods.cs" }, 0 },
                //{ new string[] { "TestData/Source/ExtensionMethods.cs" }, 1 },
            };

        [Theory]
        [MemberData(nameof(ExtensionMethods))]
        public void CollectExtensionMethodsTests(string[] paths, int expected)
        {
            // Arrange
            var generator = new OverloadsGenerator();
            var project = Verifier.CreateProject(
                paths
                .Concat(commonPaths)
                .Select(path => File.ReadAllText(path)));
            var compilation = project.GetCompilationAsync().GetAwaiter().GetResult();

            // Act
            var result = generator.CollectExtensionMethods(compilation!);

            // Assert
            Assert.Equal(expected, result.Count);
        }

        public static TheoryData<string[]> ClassesWithOverloads
            => new TheoryData<string[]> { 
                new string[] {
                    "TestData/Source/Count.ValueEnumerable.cs",
                    "TestData/Source/Select.ArraySegment.cs",
                },
            };

        [Theory]
        [MemberData(nameof(ClassesWithOverloads))]
        public void ClassesWithOverloadsShouldNotGenerate(string[] paths)
        {
            // Arrange
            var generator = new OverloadsGenerator();
            var project = Verifier.CreateProject(
                paths
                .Concat(commonPaths)
                .Select(path => File.ReadAllText(path)));
            var compilation = project.GetCompilationAsync().GetAwaiter().GetResult();

            // Act
            var extensionMethods = generator.CollectExtensionMethods(compilation!);
            var result = generator.GenerateSource(compilation!, extensionMethods);

            // Assert
            Assert.Empty(result);
        }
    }
}