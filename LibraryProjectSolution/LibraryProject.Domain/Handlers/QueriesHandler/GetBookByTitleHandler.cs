using AutoMapper;
using LibraryProject.Core;
using LibraryProject.Domain.Interfaces;
using LibraryProject.Domain.Queries;
using LibraryProject.Domain.Responses;
using MediatR;

namespace LibraryProject.Domain.Handlers.QueriesHandler
{
    public class GetBookByTitleHandler : IRequestHandler<GetBookByTitleQuery, BookResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetBookByTitleHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<BookResponse> Handle(GetBookByTitleQuery request, CancellationToken cancellationToken)
        {
            BookModel book = await _bookRepository.FindByTitle(request.Title);

            if (book == null)
            {
                throw new Exception("Sorry, I couldn't find this book in our data base :c, try another title or call some admin. person!");
            }

            return await Task.FromResult(
                _mapper.Map<BookResponse>(book)
            );
        }
    }
}