using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Infrastructure;

namespace LibraryProject.Domain.Interfaces
{
    public interface IBookRepository
    {
        Task CreateBookAsync(BookModel book);
    }
}