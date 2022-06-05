using Microsoft.AspNetCore.Identity;

namespace MonkTechWebAPI.Models
{
    public class Usuario : IdentityUser
    {
        public int SalaoId { get; set; }
    }
}
