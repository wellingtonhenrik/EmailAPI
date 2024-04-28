using EmailAPI.Application.Dtos.Response;
using EmailAPI.Application.Interface;
using EmailAPI.Domain.Interface;

namespace EmailAPI.Application.Service;

public class AuthAppService : IAuthAppService
{
    private readonly IAuthService _authService;

    public AuthAppService(IAuthService authService)
    {
        _authService = authService;
    }

    public AuhResponseDTO Authentication(string user, string pass)
    {
        var authReponse = _authService.Authentication(user, pass);
        return new AuhResponseDTO()
        {
            Message = $"{user} autenticado com sucesso",
            Token = authReponse
        };
    }
}