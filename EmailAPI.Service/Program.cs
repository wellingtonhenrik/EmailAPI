using EmailAPI.Infra.IoC.Extension;
using EmailAPI.Service.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSqaggerDoc();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddConfigure(builder.Configuration);
builder.Services.AddJwtBearer(builder.Configuration);
builder.Services.AddAuthConfig(builder.Configuration);
var app = builder.Build();

app.UseSwaggerDoc();
app.UseHttpsRedirection();
//resonsavel pela autenticação e tem que estar nessa ordem
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();

public partial class Program { }

