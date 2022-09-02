using AutoMapper;
using LibraryProject.Domain.Commands;
using LibraryProject.Domain.Interfaces;
using LibraryProject.Domain.Responses;
using LibraryProject.Domain.Services;
using LibraryProject.Infrastructure;

namespace LibraryProject.Domain.Handlers.HandlerCommands
{
    public class CreateBookHandler : IBookCommand
    {
        protected readonly IBookServices _bookService;

        protected readonly IMapper _mapper;

        public CreateBookHandler(IBookServices bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        public async Task<BookResponse> CreateBookAsync(CreateBookRequest request)
        {
            var bookModel = _mapper.Map<BookModel>(request);
            return await _bookService.Add(bookModel);

        }


    }
}