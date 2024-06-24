using CarSpecs.Models.Auth;
using CarSpecs.Services.Auth;
using Microsoft.AspNetCore.Mvc;

namespace CarSpecs.Controllers
{
    [Route("/carSpecs/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var token = await _authService.Authenticate(loginDTO.Username, loginDTO.Password);
            if (token == null)
                return Unauthorized();

            return Ok(new { Token = token });
        }
    }
}
