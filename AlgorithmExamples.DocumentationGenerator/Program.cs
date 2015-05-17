using System.IO;

namespace AlgorithmExamples.DocumentationGenerator
{
    class Program
    {
        static void Main()
        {
            DocumentGenerator gen = new DefaultDocumentGenerator();
            string output = gen.Generate();
            File.WriteAllText("../../../README.md", output);
        }
    }
}
