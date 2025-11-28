using System;
using System.Security.Claims;

namespace API.Extensions;

public static class ClaimsPrincipalExtentsions
{
    public static string GetUsername(this ClaimsPrincipal user)
    {
        return user.Identity?.Name?? throw new UnauthorizedAccessException();
    }
}
