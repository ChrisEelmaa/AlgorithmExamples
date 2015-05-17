namespace AlgorithmExamples
{
    public interface IAlgorithmImplementation
    {
        Author Author { get; }
        DifficultyLevel Level { get; }
        AsymptoticWorstCaseTimeComplexity Complexity { get; }
        AlgorithmCategory Category { get; }

        string Name { get; }
        string Description { get;  }
    }
}
