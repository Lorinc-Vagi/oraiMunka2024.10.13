using Microsoft.AspNetCore.Identity;

namespace haziDolgozat2024._10._13.Enitities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
