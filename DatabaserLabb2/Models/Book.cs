using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaserLabb2.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public required int ISBN { get; set; }
        public required string Title { get; set; }
        public short ReleaseYear { get; set; }
        public decimal Rating { get; set; }
        public List<Author>? Authors { get; set; }
        
    }

    //public class Book2
    //{
    //    public int Id { get; set; }
    //    public required int ISBN { get; set; }
    //    public required string Title { get; set; }
    //    public required string Author { get; set; }
    //    public string? Author2 { get; set; }
    //    public string? Author3 { get; set; }
    //    public short ReleaseYear { get; set; }
    //    public decimal Rating { get; set; }
    //}
}
