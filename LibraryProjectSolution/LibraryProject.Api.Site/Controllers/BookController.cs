
using LibraryProject.Domain.Commands;
using LibraryProject.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.Api.Site.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookCommand _book;
        private readonly IMediator _mediator;

        public BookController(IBookCommand book, IMediator mediator)
        {
            _book = book;
            _mediator = mediator;
        }

        [HttpPost("/CreateBook")]
        public async Task<ActionResult> CreateBook([FromBody] CreateBookRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpGet("id/{Id}")]
        public async Task<ActionResult> FindBookById([FromRoute] Guid Id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("title/{Title}")]
        public async Task<ActionResult> FindBookByTitle([FromRoute] string Title)
        {
            throw new NotImplementedException();
        }

        [HttpGet("bookLanguage/{BookLanguage}")]
        public async Task<ActionResult> FindBookByLanguage([FromRoute] string BookLanguage)
        {
            throw new NotImplementedException();
        }
    }
}