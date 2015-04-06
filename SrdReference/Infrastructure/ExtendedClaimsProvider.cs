using System.Collections.Generic;
using System.Security.Claims;

namespace SrdReference.Infrastructure
{
    public static class ExtendedClaimsProvider
    {
        public static IEnumerable<Claim> GetClaims(ApplicationUser user)
        {

            List<Claim> claims = new List<Claim>();

            if (user.State == "CO")
            {
                claims.Add(CreateClaim("COL", "1"));

            }
            else
            {
                claims.Add(CreateClaim("COL", "0"));
            }

            return claims;
        }

        public static Claim CreateClaim(string type, string value)
        {
            return new Claim(type, value, ClaimValueTypes.String);
        }

    }
}