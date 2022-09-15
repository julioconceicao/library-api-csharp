using AutoMapper;
using MediatR;
using LibraryProject.Core;
using LibraryProject.Domain.Interfaces;
using LibraryProject.Domain.Queries;
using LibraryProject.Domain.Responses;

namespace LibraryProject.Domain.Handlers.QueriesHandler
{
    public class GetBookByLanguageHandler : IRequestHandler<GetBookByLanguageQuery, IEnumerable<BookResponse>>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetBookByLanguageHandler(
        IBookRepository bookRepository, 
        IMapper mapper
        )
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Method for searching books by language
        /// </summary>
        /// <param name="request.BookLanguage">language book (string)</param>
        // <returns>List of books or Exception notfound</returns>
        public async Task<IEnumerable<BookResponse>> Handle(GetBookByLanguageQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<BookModel> books = await _bookRepository.FindByLanguage(request.BookLanguage);
            
            if (books is null)
            {
                throw new Exception($"There isn't any book in {request.BookLanguage}. ");
            }

            return await Task.FromResult(
                _mapper.Map<IEnumerable<BookResponse>>(books)
            );
        }
    }
}