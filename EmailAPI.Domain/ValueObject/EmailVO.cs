namespace EmailAPI.Domain.ValueObject;

public class EmailVO
{
    public string? MailTo { get; set; }
    public string? Subject { get; set; }
    public string? Body { get; set; }
}