using Microsoft.AspNetCore.Identity;

namespace Week6FS.Models
{
    public class ApplicationUser : IdentityUser 
    {
        // add custom fields for registration
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
    }
}
