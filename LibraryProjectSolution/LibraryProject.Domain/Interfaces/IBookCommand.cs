using LibraryProject.Domain.Commands;
using LibraryProject.Domain.Responses;

namespace LibraryProject.Domain.Interfaces
{
    public interface IBookCommand
    {
        Task<BookResponse> CreateBookAsync(CreateBookRequest Book);
    }
}