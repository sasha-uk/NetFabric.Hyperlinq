using Microsoft.CodeAnalysis;
using NetFabric.Assertive;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace NetFabric.Hyperlinq.SourceGenerator.UnitTests
{
    public partial class GeneratorTests
    {
        static readonly string[] commonPaths = new string[] {
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

        // -----------------------------------------------------

        public static TheoryData<string[], int> ExtensionMethods
            => new TheoryData<string[], int> {
                { new string[] { "TestData/Source/NoExtensionMethods.cs" }, 0 },
                { new string[] { "TestData/Source/ExtensionMethods.cs" }, 1 },
            };

        [Theory]
        [MemberData(nameof(ExtensionMethods))]
        public async Task CollectExtensionMethodsTests(string[] paths, int expected)
        {
            // Arrange
            var generator = new OverloadsGenerator();
            var project = Verifier.CreateProject(
                paths
                .Concat(commonPaths)
                .Select(path => File.ReadAllText(path)));
            var compilation = await project.GetCompilationAsync().ConfigureAwait(false);

            // Act
            var result = generator.CollectExtensionMethods(compilation!);

            // Assert
            _ = result.Count.Must()
                .BeEqualTo(expected);
        }

        // -----------------------------------------------------

        public static TheoryData<string[]> ClassesWithOverloads
            => new TheoryData<string[]> {
                new string[] {
                    "TestData/Source/Count.ValueEnumerable.cs",
                    "TestData/Source/Select.ArraySegment.cs",
                },
                new string[] {
                    "TestData/Source/Count.ValueEnumerable.cs",
                    "TestData/Source/Select.ValueEnumerable.cs",
                },
            };

        [Theory]
        [MemberData(nameof(ClassesWithOverloads))]
        public async Task ClassesWithOverloadsShouldNotGenerate(string[] paths)
        {
            // Arrange
            var generator = new OverloadsGenerator();
            var project = Verifier.CreateProject(
                paths
                .Concat(commonPaths)
                .Select(path => File.ReadAllText(path)));
            var compilation = await project.GetCompilationAsync().ConfigureAwait(false);

            // Act
            var extensionMethods = generator.CollectExtensionMethods(compilation!);
            var result = generator.GenerateSource(compilation!, extensionMethods);

            // Assert
            _ = result.Must()
                .BeEnumerableOf<(INamedTypeSymbol, INamedTypeSymbol, string)>()
                .BeEmpty();
        }

        // -----------------------------------------------------

        public static TheoryData<string[], string[]> GeneratorSources
            => new TheoryData<string[], string[]> {
                {
                    new string[] {
                        "TestData/Source/Count.ValueEnumerable.cs",
                        "TestData/Source/Where.ValueEnumerable.cs",
                    },
                    new string[] {
                        "TestData/Results/Where.ValueEnumerable.Count.ValueEnumerable.cs",
                    }
                },
            };

        [Theory]
        [MemberData(nameof(GeneratorSources))]
        public async Task GeneratorSourcesShouldGenerate(string[] paths, string[] results)
        { 
            // Arrange
            var generator = new OverloadsGenerator();
            var project = Verifier.CreateProject(
                paths
                .Concat(commonPaths)
                .Select(path => File.ReadAllText(path)));
            var compilation = await project.GetCompilationAsync().ConfigureAwait(false);

            // Act
            var extensionMethods = generator.CollectExtensionMethods(compilation!);
            var result = generator.GenerateSource(compilation!, extensionMethods);

            // Assert
            _ = result.Select(item => item.Item3)
                .Must()
                .BeEnumerableOf<string>()
                .BeEqualTo(results.Select(path => File.ReadAllText(path)));
        }
    }
}