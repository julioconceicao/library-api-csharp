using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Domain.Responses;
using LibraryProject.Infrastructure;

namespace LibraryProject.Domain.Interfaces.Implementations
{
    public class BookServices : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookServices(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<CreateBookResponse> CreateBookAsync(BookModel book)
        {
            var response = new CreateBookResponse();
            await _bookRepository.CreateBookAsync(book);
            return response;
        }
    }
}