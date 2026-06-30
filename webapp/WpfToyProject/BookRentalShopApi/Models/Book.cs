namespace BookRentalApi.Models
{
    public class Book
    {
        public int BookIdx { get; set; }

        public string? Author { get; set; }

        public string DivCode { get; set; } = string.Empty;

        public string? BookName { get; set; }

        public DateTime? ReleaseDt { get; set; }

        public string? Isbn { get; set; }

        public decimal? Price { get; set; }
    }
}