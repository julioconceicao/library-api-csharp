using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Domain.Interfaces.GenericInterfaces;
using LibraryProject.Infrastructure;

namespace LibraryProject.Domain.Interfaces
{
    public interface IBookRepository :IRepository<BookModel>
    {
    }
}