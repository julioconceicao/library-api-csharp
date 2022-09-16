using MediatR;
using Microsoft.AspNetCore.Mvc;
using LibraryProject.Domain.Commands;
using LibraryProject.Domain.Queries;

namespace LibraryProject.Api.Site.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookController(
        IMediator mediator
        )
        {
            _mediator = mediator;
        }

        [HttpPost("/CreateBook")]
        public async Task<ActionResult> CreateBook([FromBody] CreateBookRequest request)
        {
            try
            {
                var result = await _mediator.Send(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("/DeletBook/{Id}")]
        public async Task<ActionResult> DeleteBook([FromRoute] DeleteBookRequest request)
        {
            try
            {
                var result = await _mediator.Send(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
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

        /// <summary>
        /// Searh books int the language
        /// </summary>
        /// <param name="BookLanguage">Language book (string)</param>
        /// <returns>IActionResult(List books)</returns>
        [HttpGet("bookLanguage/{BookLanguage}")]
        public async Task<IActionResult> FindBookByLanguage([FromRoute] string BookLanguage)
        {
            try
            {
                var query = new GetBookByLanguageQuery(BookLanguage);
                var result = await _mediator.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}