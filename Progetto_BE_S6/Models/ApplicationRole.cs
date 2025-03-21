using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Progetto_BE_S6.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> ApplicationUserRole { get; set; }
    }
}
