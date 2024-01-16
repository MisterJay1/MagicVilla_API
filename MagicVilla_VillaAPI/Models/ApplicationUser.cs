using Microsoft.AspNetCore.Identity;

namespace SigmaVilla_VillaAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}