using Microsoft.AspNetCore.Identity;

namespace zaliczenie.Data
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole(): base() { }

        public ApplicationRole(string roleName)
            : base(roleName) { }

        public virtual ICollection<IdentityRoleClaim<string>> Claims { get; set; }
    }
}
