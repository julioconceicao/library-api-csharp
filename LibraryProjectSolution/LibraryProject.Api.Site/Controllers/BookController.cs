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

        public BookController(IBookCommand book)
        {
            _book = book;
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
    }
}