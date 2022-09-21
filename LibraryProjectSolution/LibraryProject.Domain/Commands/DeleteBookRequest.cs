using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace LibraryProject.Domain.Commands
{
    public class DeleteBookRequest : IRequest<object>
    {
        public Guid Id { get; set; }
    }
}