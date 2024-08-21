namespace FIrstProject.Model
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateddDate { get; set; }
        public string ISBNNumber { get; set; }
        public  int BookCoverId { get; set; }
       // public BookCover BookCover { get; set; }
        public int BookWritterId { get; set; }
       // public BookWritters BookWritters { get; set; }
       
    }
}
