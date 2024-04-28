namespace EmailAPI.Domain.Interface;

public interface IAuthService
{
    string Authentication(string user, string pass);
}