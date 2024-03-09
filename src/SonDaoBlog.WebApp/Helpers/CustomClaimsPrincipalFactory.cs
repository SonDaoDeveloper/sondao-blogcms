using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using SonDaoBlog.Core.Domain.Identity;
using SonDaoBlog.Core.SeedWorks.Constants;
using System.Security.Claims;

namespace SonDaoBlog.WebApp.Helpers
{
    public class CustomClaimsPrincipalFactory : UserClaimsPrincipalFactory<AppUser, AppRole>
    {
        public CustomClaimsPrincipalFactory(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IOptions<IdentityOptions> options) : base(userManager, roleManager, options)
        {
        }

        public override async Task<ClaimsPrincipal> CreateAsync(AppUser user)
        {
            var principal = await base.CreateAsync(user);
            ((ClaimsIdentity)principal.Identity)?.AddClaims(new[] {
                new Claim(UserClaims.Id, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(UserClaims.FirstName, user.FirstName),
            });
            return principal;
        }
    }
}
