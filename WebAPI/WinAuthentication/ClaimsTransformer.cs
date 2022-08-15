using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace WebAPI.WinAuthentication
{
    public class ClaimsTransformer: IClaimsTransformation
    {
        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            var wi = (WindowsIdentity)principal.Identity;
            if (wi.Groups != null)
            {
                foreach (var group in wi.Name) 
                {
                    try
                    {
                        var claim = new Claim(wi.User, group.Value);
                        wi.AddClaim(claim);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return Task.FromResult(principal);
        }
    }
}
