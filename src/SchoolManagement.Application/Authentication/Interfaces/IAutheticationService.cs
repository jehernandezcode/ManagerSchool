
using SchoolManagement.Application.Authentication.Dtos;

namespace SchoolManagement.Application.Authentication.Interfaces
{
    public interface IAutheticationService
    {
        Task<TokenDto> GenerateToken(GenerateTokenDto credentials);
    }
}
