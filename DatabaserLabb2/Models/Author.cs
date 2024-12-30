using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaserLabb2.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public required string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public List<Book>? Books { get; set; }
        


    }
}
