using EmailAPI.Application.Dtos.Response;

namespace EmailAPI.Application.Interface;

public interface IAuthAppService
{
    AuhResponseDTO Authentication(string user, string pass);
}