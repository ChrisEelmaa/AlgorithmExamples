using System.IO;

namespace AlgorithmExamples.DocumentationGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentGenerator gen = new DefaultDocumentGenerator();
            string output = gen.Generate();
            File.WriteAllText("../../../README.md", output);
        }
    }
}
