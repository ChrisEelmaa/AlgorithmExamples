namespace AlgorithmExamples
{
    public sealed class Author
    {
        public static Author ErtiChrisEelmaa = new Author
        {
            FullName = "Erti-Chris Eelmaa",
            WebPage = "http://chriseelmaa.com"
        };

        public string FullName { get; private set; }
        public string WebPage { get; private set; }
    }
}
