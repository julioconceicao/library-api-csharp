using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Domain.Commands;
using LibraryProject.Domain.Interfaces;
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
    }
}