using SchoolManagement.Application.Authentication.Dtos;
using SchoolManagement.Application.Authentication.Interfaces;
using SchoolManagement.Domain.Common;

namespace SchoolManagement.Application.Authentication.Services
{
    public class AuthenticationService : IAutheticationService
    {
        private readonly IAuthenticationServiceInfra _authenticationServiceInfra;

        public AuthenticationService(IAuthenticationServiceInfra authenticationServiceInfra)
        {
            _authenticationServiceInfra = authenticationServiceInfra;
        }

        public async Task<TokenDto> GenerateToken(GenerateTokenDto credentials)
        {
            var token = await _authenticationServiceInfra.GenerateToken(credentials.Username, credentials.Role);
            return new TokenDto
            {
                Token = token,
            };
        }
    }
}
