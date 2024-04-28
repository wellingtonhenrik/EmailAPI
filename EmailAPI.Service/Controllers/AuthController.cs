using EmailAPI.Application.Dtos.Requets;
using EmailAPI.Application.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmailAPI.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthAppService _authAppService;

        public AuthController(IAuthAppService authAppService)
        {
            _authAppService = authAppService;
        }

        [HttpPost]
        public IActionResult Auth(AuthRequestDTO dto)
        {
            return StatusCode(200,_authAppService.Authentication(dto.Key, dto.Pass));
        }
    }
}
