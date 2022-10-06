namespace DifferentBetweenIsAndAsKeyword
{
    internal class Author
    {
        public string Name { get; set; }
        public int Rank { get; set; }

        public void Details(string name, int rank)
        {
            Name = name;
            Rank = rank;
        }
    }
}
