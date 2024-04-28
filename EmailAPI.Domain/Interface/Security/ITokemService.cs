namespace EmailAPI.Domain.Interface.Security;

public interface ITokemService
{
    string CreateToken(string user);
}