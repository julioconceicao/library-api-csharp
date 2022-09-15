using AutoMapper;
using LibraryProject.Core;
using LibraryProject.Domain.Interfaces;
using LibraryProject.Domain.Queries;
using LibraryProject.Domain.Responses;
using MediatR;

namespace LibraryProject.Domain.Handlers.QueriesHandler
{
    public class GetBookByLanguageHandler : IRequestHandler<GetBookByLanguageQuery, BookResponse>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetBookByLanguageHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<BookResponse> Handle(GetBookByLanguageQuery request, CancellationToken cancellationToken)
        {
            BookModel book = await _bookRepository.FindByLanguage(request.Language);
            if (book == null)
            {
                throw new DllNotFoundException($"There isn't any book in {request.Language}. ");
            }

            return await Task.FromResult(
                _mapper.Map<BookResponse>(book)
            );
        }
    }
}