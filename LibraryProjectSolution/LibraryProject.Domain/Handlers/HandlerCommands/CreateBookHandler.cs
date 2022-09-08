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
        protected readonly IBookServices _bookServices;

        protected readonly IMapper _mapper;

        public CreateBookHandler(IBookServices bookServices, IMapper mapper)
        {
            _bookServices = bookServices;
            _mapper = mapper;
        }

        public async Task<BookResponse> CreateBookAsync(CreateBookRequest request)
        {
            var bookModel = _mapper.Map<BookModel>(request);
            return await _bookServices.Add(bookModel);
        }
    }
}