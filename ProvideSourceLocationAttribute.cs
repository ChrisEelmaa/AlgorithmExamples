using System;
using System.Runtime.CompilerServices;

namespace AlgorithmExamples
{
    public sealed class ProvideSourceLocation : Attribute
    {
        public readonly string File;

        public ProvideSourceLocation([CallerFilePath] string file = "")
        {
            File = file;
        }

        public override string ToString()
        {
            return File;
        }
    }
}
