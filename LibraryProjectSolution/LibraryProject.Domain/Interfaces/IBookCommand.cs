using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Domain.Commands;
using LibraryProject.Domain.Responses;

namespace LibraryProject.Domain.Interfaces
{
    public interface IBookCommand
    {
        Task<CreateBookResponse> CreateBookAsync(CreateBookRequest Book);
    }
}