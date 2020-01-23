using System;

namespace NetFabric.Hyperlinq
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
    public sealed class GeneratorIgnoreAttribute : Attribute
    {
        public bool Value { get; }

        public GeneratorIgnoreAttribute(bool value = true)
            => Value = value;
    }
}