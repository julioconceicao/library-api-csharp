using LibraryProject.Domain.Responses;
using LibraryProject.Infrastructure;

namespace LibraryProject.Domain.Services
{
    public interface IBookServices
    {
        Task<BookResponse> Add(BookModel book);
        Task<BookResponse> FindById(Guid id);
        Task <BookResponse> FindByTitle(string title);

        Task<BookResponse> FindByLanguage(string bookLanguage);
    }
}