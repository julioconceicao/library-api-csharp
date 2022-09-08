using LibraryProject.Domain.Interfaces.GenericInterfaces;
using LibraryProject.Infrastructure;

namespace LibraryProject.Domain.Interfaces
{
    public interface IBookRepository :IRepository<BookModel>
    {
    }
}