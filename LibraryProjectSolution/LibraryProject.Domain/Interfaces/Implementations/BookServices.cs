using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LibraryProject.Domain.Responses;
using LibraryProject.Infrastructure;

namespace LibraryProject.Domain.Interfaces.Implementations
{
    public class BookServices : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookServices(IBookRepository bookRepository, IMapper mapper)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }
        public async Task<CreateBookResponse> CreateBookAsync(BookModel book)
        {
            var response = _mapper.Map<CreateBookResponse>(book);
            await _bookRepository.CreateBookAsync(book);
            return response;
        }
    }
}