using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace AlgorithmExamples.DocumentationGenerator
{
    class DefaultDocumentGenerator : DocumentGenerator
    {
        public override string Generate()
        {
            Data.Clear();

            Data.Append(File.ReadAllText("MainTemplate.md"));
                
            WriteOverview();
            WriteImplementations();

            return Data.ToString();
        }

        public void WriteOverview()
        {
            var overview = File.ReadAllText("Overview.md");
            overview = string.Format(overview, Implementations.Count);

            Data.Replace("{Overview}", overview);
        }

        public void WriteImplementations()
        {
            var overview = File.ReadAllText("Implementation.md");
            var sb = new StringBuilder();

            foreach (var implementation in Implementations)
            {
                var path = GithubHelper.GetSourceCodeFilePathForImplementation(implementation);
                sb.Append(string.Format(overview, 
                    implementation.Name, 
                    path, 
                    implementation.Description));
            }

            Data.Replace("{Implementations}", sb.ToString());
        }
    }
}
