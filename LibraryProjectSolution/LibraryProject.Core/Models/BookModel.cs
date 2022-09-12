using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LibraryProject.Core
{
    [Table("BookModel")]

    public class BookModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int PagesNumber { get; set; }

        [Required]
        public string BookLanguage { get; set; }
    }
}