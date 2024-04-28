using EmailAPI.Application.Dtos.Requets;
using EmailAPI.Application.Dtos.Response;

namespace EmailAPI.Application.Interface;

public interface IEmailAppService
{
    EmailResponseDto SendMail(EmailRequestDto dto);
}