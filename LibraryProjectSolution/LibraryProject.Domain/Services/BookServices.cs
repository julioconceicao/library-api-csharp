using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LibraryProject.Domain.Interfaces;
using LibraryProject.Domain.Responses;
using LibraryProject.Infrastructure;

namespace LibraryProject.Domain.Services
{
    public class BookServices : IBookServices
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookServices(IBookRepository bookRepository, IMapper mapper)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }
        public async Task<BookResponse> Add(BookModel book)
        {
            var response = _mapper.Map<BookResponse>(book);
            await _bookRepository.Add(book);
            return response;
        }
        public async Task<BookResponse> FindById(Guid id)
        {
            var response = _mapper.Map<BookResponse>(await _bookRepository.FindById(id));
            return response;
        }
    }
}