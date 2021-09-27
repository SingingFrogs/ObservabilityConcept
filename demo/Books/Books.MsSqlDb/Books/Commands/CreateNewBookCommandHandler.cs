using System.Threading;
using System.Threading.Tasks;
using Books.Domain.Books;
using Books.Domain.Books.Commands;
using MediatR;

namespace Books.MsSqlDb.Books.Commands
{
    public class CreateNewBookCommandHandler: IRequestHandler<CreateNewBookCommand, Book>
    {
        public Task<Book> Handle(CreateNewBookCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new Book(request.BookName));
        }
    }
}