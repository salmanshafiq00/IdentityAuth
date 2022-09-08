using System.ComponentModel.DataAnnotations;

namespace IdentityAuth.Models
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
