using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;

namespace Caamtroh.Security
{
    public static class SessionPersister
    {


        public static string GetClaimInfo(string nameIdentifier)
        {
            ClaimsPrincipal Principal = Thread.CurrentPrincipal as ClaimsPrincipal;
            var identificador =
                Principal.Claims.FirstOrDefault(p => p.Type == nameIdentifier);
            if (identificador != null)
                return identificador.Value;
            else
                return "";
        }
    }
}