using System;
using System.Threading.Tasks;
using LibraryProject.Domain.Commands;
using LibraryProject.Domain.Interfaces;
using LibraryProject.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.Api.Site.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookCommand _book;
        private readonly IBookServices _service;

        public BookController(IBookCommand book, IBookServices service)
        {
            _book = book;
            _service = service;
        }

        [HttpPost("/CreateBook")]
        public async Task<ActionResult> CreateBook([FromBody] CreateBookRequest request)
        {
            try
            {
                var response = await _book.CreateBookAsync(request);
                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("id/{Id}")]
        public async Task<ActionResult> FindBookById([FromRoute] Guid Id)
        {
            try
            {
                var response = await _service.FindById(Id);
                return Ok(response);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpGet("title/{Title}")]
        public async Task<ActionResult> FindBookByTitle([FromRoute] string Title)
        {
            try
            {
                var response = await _service.FindByTitle(Title);
                return Ok(response);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpGet("bookLanguage/{BookLanguage}")]
        public async Task<ActionResult> FindBookByLanguage([FromRoute] string BookLanguage)
        {
            try
            {
                var response = await _service.FindByLanguage(BookLanguage);
                return Ok(response);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}