using AutoMapper;
using LibraryProject.Domain.Commands;
using LibraryProject.Domain.Interfaces;
using LibraryProject.Domain.Responses;
using LibraryProject.Core;
using MediatR;

namespace LibraryProject.Domain.Handlers.HandlerCommands
{
    public class CreateBookHandler : IRequestHandler<CreateBookRequest, BookResponse>
    {
        protected readonly IBookRepository _bookRepository;

        protected readonly IMapper _mapper;

        public CreateBookHandler(IBookRepository _bookRepository, IMapper mapper)
        {
            _bookRepository = _bookRepository;
            _mapper = mapper;
        }

        public async Task<BookResponse> Handle(CreateBookRequest request, CancellationToken cancellationToken)
        {
            var bookAlreadyExists = await _bookRepository.FindByTitle(request.Title);

            if (bookAlreadyExists != null)
            {
                throw new InvalidOperationException($"{request.Title} This book is already here");
            }

            BookModel book = new BookModel
            {
                Title = request.Title,
                Author = request.Author,
                Genre = request.Genre,
                Year = request.Year,
                PagesNumber = request.PagesNumber,
                BookLanguage = request.BookLanguage
            };

            await _bookRepository.Add(book);

            return _mapper.Map<BookResponse>(book);
        }


    }
}