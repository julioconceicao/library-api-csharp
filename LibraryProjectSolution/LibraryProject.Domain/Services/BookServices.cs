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

        public async Task Delete(Guid id)
        {
            var exists = await _bookRepository.FindById(id);
            
            if (exists == null)
            {
                throw new Exception("Couldn't find the book with the specified id");
            }

            await _bookRepository.Delete(id);
        }

        public async Task<BookResponse> FindById(Guid id)
        {
            var response = _mapper.Map<BookResponse>(await _bookRepository.FindById(id));
            return response;
        }

        public async Task<BookResponse> FindByLanguage(string bookLanguage)
        {
            var response = _mapper.Map<BookResponse>(await _bookRepository.FindByLanguage(bookLanguage));

            if (response == null)
            {
                throw new Exception("Could not find any book in this language.");
            }

            return response;
        }

        public async Task<BookResponse> FindByTitle(string title)
        {
            var response = _mapper.Map<BookResponse>(await _bookRepository.FindByTitle(title));

            if (response == null)
            {
                throw new Exception("Couldn't find this title.");
            }

            return response;
        }


    }
}