using System;

namespace SatorImaging.UnitySourceGenerator
{
    ///<summary>NOTE: Implement "IUnitySourceGenerator" (C# 11.0)</summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class UnitySourceGeneratorAttribute : Attribute
    {
        public UnitySourceGeneratorAttribute(Type generatorClass = null)
        {
            GeneratorClass = generatorClass;
        }

        public bool OverwriteIfFileExists { get; set; } = false;
        public Type GeneratorClass { get; set; }

    }
}
