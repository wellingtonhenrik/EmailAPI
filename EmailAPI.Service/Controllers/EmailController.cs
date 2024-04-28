using EmailAPI.Application.Dtos.Requets;
using EmailAPI.Application.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmailAPI.Service.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class EmailController : ControllerBase
{
    private readonly IEmailAppService _emailAppService;

    public EmailController(IEmailAppService emailAppService)
    {
        _emailAppService = emailAppService;
    }

    [HttpPost]
    public IActionResult SendEmail(EmailRequestDto dto)
    {
        return StatusCode(200, _emailAppService.SendMail(dto));
    }
}