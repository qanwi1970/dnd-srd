using System.Collections.Generic;
using System.Security.Claims;

namespace SrdReference.Infrastructure
{
    public class RolesFromClaims
    {
        public static IEnumerable<Claim> CreateRolesBasedOnClaims(ClaimsIdentity identity)
        {
            List<Claim> claims = new List<Claim>();

            if (identity.HasClaim(c => c.Type == "COL" && c.Value == "1") &&
                identity.HasClaim(ClaimTypes.Role, "Admin"))
            {
                claims.Add(new Claim(ClaimTypes.Role, "LocalAdmins"));
            }

            return claims;
        }
    }
}