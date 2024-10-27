using Microsoft.AspNetCore.Identity;

namespace zaliczenie.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser(): base() { }
        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
    }

}
