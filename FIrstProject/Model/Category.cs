using System.ComponentModel.DataAnnotations.Schema;

namespace FIrstProject.Model
{
    public class Category
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        public int DisplyOrder { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
      //  [NotMapped]
       // public IFormFile CatogoryImage { get; set; }
    }
}
