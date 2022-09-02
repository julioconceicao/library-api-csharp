using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Interfaces.GenericInterfaces
{
    public interface IRepository <T>
    {
        Task Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);

        Task <T> FindById (Guid id);
    }
}