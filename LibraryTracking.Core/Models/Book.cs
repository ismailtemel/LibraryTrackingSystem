namespace LibraryTracking.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Writer { get; set; }
        public int PageCount { get; set; }
        public string UserId { get; set; }
    }
}
