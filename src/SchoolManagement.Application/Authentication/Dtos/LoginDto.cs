
using System.ComponentModel;

namespace SchoolManagement.Application.Authentication.Dtos
{
    public class LoginDto
    {
        [DefaultValue("testUser")]
        public string Username { get; set; } = String.Empty;

        [DefaultValue("Password1")]
        public string Password { get; set; } = String.Empty;
    }
}
