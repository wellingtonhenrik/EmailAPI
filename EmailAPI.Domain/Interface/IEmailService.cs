using EmailAPI.Domain.ValueObject;

namespace EmailAPI.Domain.Interface;

public interface IEmailService
{
    public void SendMail(EmailVO vo);
}