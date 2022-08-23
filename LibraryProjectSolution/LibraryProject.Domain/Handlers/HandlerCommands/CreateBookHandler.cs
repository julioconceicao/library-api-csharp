using AutoMapper;
using LibraryProject.Domain.Commands;
using LibraryProject.Domain.Interfaces;
using LibraryProject.Domain.Responses;
using LibraryProject.Infrastructure;

namespace LibraryProject.Domain.Handlers.HandlerCommands
{
    public class CreateBookHandler : IBookCommand
    {
        protected readonly IBookService _bookService;

        protected readonly IMapper _mapper;

        public CreateBookHandler(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        public async Task<CreateBookResponse> CreateBookAsync(CreateBookRequest request)
        {
            var bookModel = _mapper.Map<BookModel>(request);
            return await _bookService.CreateBookAsync(bookModel);

        }


    }
}