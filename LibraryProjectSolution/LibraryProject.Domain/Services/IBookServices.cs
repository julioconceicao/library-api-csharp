using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Domain.Responses;
using LibraryProject.Infrastructure;

namespace LibraryProject.Domain.Services
{
    public interface IBookServices
    {
        Task<BookResponse> Add(BookModel book);
        Task<BookResponse> FindById(Guid id);
    }
}