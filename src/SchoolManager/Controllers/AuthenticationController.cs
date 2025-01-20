using ManagerSchool.Exceptions;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Application.Authentication.Dtos;
using SchoolManagement.Application.Authentication.Interfaces;

namespace SchoolManager.Controllers
{
    [Tags("AuthenticationController")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAutheticationService _authenticationService;

        public AuthenticationController(IAutheticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost()]
        [ProducesResponseType((typeof(TokenDto)),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]

        public async Task<IActionResult> CreateCourse([FromBody] LoginDto credentials)
        {
            if(credentials.Username == "testUser" && credentials.Password == "Password1")
            {
            var token = await _authenticationService.GenerateToken(
                new GenerateTokenDto {
                    Username = credentials.Username,
                    Role = "Admin"});
            return Ok(token);
            }else
            {
                throw new UnAuthenticationException("authetication failed");
            }

        }
    }
}
