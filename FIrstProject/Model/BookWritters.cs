using System.ComponentModel.DataAnnotations;

namespace FIrstProject.Model
{
    public class BookWritters
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
      //  public ICollection<Book> Books { get; set; }
       // public ICollection<BookCover> BookCovers { get; set; }

    }
}
