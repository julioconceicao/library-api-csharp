using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Domain.Responses;
using MediatR;

namespace LibraryProject.Domain.Commands
{
    public class UpdateBookRequest : IRequest<BookResponse>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int PagesNumber { get; set; }
        public string BookLanguage { get; set; }
    }
}