namespace EmailAPI.Application.Dtos.Requets;

public class EmailRequestDto
{
    public string? MailTo { get; set; }
    public string? Subject { get; set; }
    public string? Body { get; set; }

}