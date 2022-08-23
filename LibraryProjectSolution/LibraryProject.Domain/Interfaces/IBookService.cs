using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Domain.Responses;
using LibraryProject.Infrastructure;

namespace LibraryProject.Domain.Interfaces
{
    public interface IBookService
    {
        Task<CreateBookResponse> CreateBookAsync(BookModel book);
    }
}