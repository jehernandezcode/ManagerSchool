
using System.Security.Claims;

namespace SchoolManagement.Domain.Common;

public interface IAuthenticationServiceInfra
{
    Task<string> GenerateToken(string username, string role);
    ClaimsPrincipal? ValidateToken(string token);
}
