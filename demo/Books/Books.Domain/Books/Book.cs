namespace Books.Domain.Books
{
    public sealed class Book
    {
        public Book(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}