namespace EmailAPI.Application.Dtos.Response;

public class AuhResponseDTO
{
    public string? Message { get; set; }
    public string? Client { get; set; }
    public string? Token { get; set; }
    public DateTime Expiration { get; set; }
}