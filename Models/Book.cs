using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Models
{
    public class Book
    {
        [Key]
        public int Bookid { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime EditionYear { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }

        //Foreign key for Image
        public int Userid { get; set; }

        [ForeignKey("Userid")]
        public virtual User? Id { get; set; }
    }
}