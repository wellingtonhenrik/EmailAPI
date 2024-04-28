using EmailAPI.Application.Dtos.Requets;
using EmailAPI.Application.Dtos.Response;
using EmailAPI.Application.Interface;
using EmailAPI.Domain.Interface;
using EmailAPI.Domain.ValueObject;

namespace EmailAPI.Application.Service;

public class EmailAppService : IEmailAppService
{
    private readonly IEmailService _emailService;

    public EmailAppService(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public EmailResponseDto SendMail(EmailRequestDto dto)
    {
        try
        {
            var emailVO = new EmailVO()
            {
                Body = dto.Body,
                Subject = dto.Subject,
                MailTo = dto.MailTo,
            };

            _emailService.SendMail(emailVO);

            var emailResponseDto = new EmailResponseDto()
            {
                Messagem = $"Email enviado com sucesso para {emailVO.MailTo}"
            };

            return emailResponseDto;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}