using EmailAPI.Domain.Exceptions;
using EmailAPI.Domain.Interface;
using EmailAPI.Domain.Interface.Security;
using Microsoft.Extensions.Options;

namespace EmailAPI.Domain.Service;

public class AuthService : IAuthService
{
    private readonly AuthSettings _authSettings;
    private readonly ITokemService _tokemService; 
    public AuthService(IOptions<AuthSettings>  tokenSetings, ITokemService tokemService)
    {
        _tokemService = tokemService;
        _authSettings = tokenSetings.Value;
    }

    public string Authentication(string user, string pass)
    {
        if (!_authSettings.User.Equals(user) && _authSettings.Pass.Equals(pass))
            throw new AcessDeniedException();

        return _tokemService.CreateToken(user);
    }
}