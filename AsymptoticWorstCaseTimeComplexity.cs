namespace AlgorithmExamples
{
    public enum AsymptoticWorstCaseTimeComplexity
    {
        NotSpecified,

        ConstantTime, // O(1)
        LogLogarithmic, // O(loglogn)
        Logarithmic, // O(logn)
        Linear, // O(n)
        Linearithmic, // O(nlogn)
        Quadratic, // O(n^2)
        Cubic, // O(n^3)
        Exponential, // O(a^n)

        Factorial, // O(n!)
    }
}
