using AutoMapper;
using LibraryProject.Core;
using LibraryProject.Domain.Interfaces;
using LibraryProject.Domain.Queries;
using LibraryProject.Domain.Responses;

namespace LibraryProject.Domain.Handlers.QueriesHandler
{
    public class GetBookByIdHandler
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        
        public GetBookByIdHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        
        public async Task<BookResponse> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            BookModel book = await _bookRepository.FindById(request.Id);
            if(book == null)
            {
                throw new DllNotFoundException($"Couldn't find book with id: {request.Id}");
            }
            return await Task.FromResult(
                _mapper.Map<BookResponse>(book)
            );
        }

    }
}