using System.Security.Principal;
using System.Threading.Tasks;
using Books.Domain.Books.Commands;
using Books.WebApi.Controllers.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Books.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewBook(CreateBookRequest createBookRequest)
        {
            var result = await _mediator.Send(new CreateNewBookCommand(createBookRequest.Name));
            var model = new CreateBookResponse()
            {
                Name = result.Name
            };

            return Ok(model);
        }
    }
}