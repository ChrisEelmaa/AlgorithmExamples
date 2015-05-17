using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using AlgorithmExamples.Sorting.ComparisonBased;

namespace AlgorithmExamples.DocumentationGenerator
{
    public abstract class DocumentGenerator
    {
        private readonly StringBuilder _data = new StringBuilder();

        public IList<IAlgorithmImplementation> Implementations { get; private set; }

        protected StringBuilder Data
        {
            get
            {
                return _data;
            }
        }

        public abstract string Generate();

        protected DocumentGenerator()
        {
            Implementations = GetImplementations().ToList();
        }

        

        private IEnumerable<IAlgorithmImplementation> GetImplementations()
        {
            return Assembly.GetAssembly(typeof(IAlgorithmImplementation))
                .GetTypes()
                .Where(type => type
                    .GetInterfaces()
                    .Contains(typeof(IAlgorithmImplementation)))
                .Where(type => !type.IsAbstract)
                .Where(type => !type.IsInterface)
                .Where(type => type.IsClass).Select(type => (IAlgorithmImplementation) Create(type));
        }

        private object Create(Type type)
        {
            if (type == typeof(BubbleSort<>))
                return new BubbleSort<int>();

            if (type == typeof(SelectionSort<>))
                return new SelectionSort<int>();

            return Activator.CreateInstance(type);
        }
    }
}
