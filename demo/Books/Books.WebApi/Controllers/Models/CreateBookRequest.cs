namespace Books.WebApi.Controllers.Models
{
    public class CreateBookRequest
    {
        public string Name { get; set; }
    }
    
    
    public class CreateBookResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}