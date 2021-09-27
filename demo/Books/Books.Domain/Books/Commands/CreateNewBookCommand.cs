using MediatR;

namespace Books.Domain.Books.Commands
{
    public class CreateNewBookCommand : IRequest<Book>
    {
        public CreateNewBookCommand(string bookName)
        {
            BookName = bookName;
        }

        public string BookName { get; }
    }
}