using System;
using System.Reflection;

namespace AlgorithmExamples.DocumentationGenerator
{
    public static class GithubHelper
    {
        public static string GetSourceCodeFilePathForImplementation(IAlgorithmImplementation implementation)
        {
            var path = implementation.GetType()
                    .GetCustomAttribute<ProvideSourceLocation>(true).File;

            var algoExamples = "\\AlgorithmExamples\\";
            var start = path.IndexOf(algoExamples,
                StringComparison.InvariantCultureIgnoreCase);

            path = path.Substring(start + algoExamples.Length);
            path = path.Replace("\\", "/");

            path = string.Format(
                "https://github.com/ChrisEelmaa/AlgorithmExamples/blob/master/{0}", path);

            return path;
        }
    }
}
