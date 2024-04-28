using System.ComponentModel.DataAnnotations;

namespace EmailAPI.Application.Dtos.Requets;

public class AuthRequestDTO
{
    [Required(ErrorMessage = "Informe usuario")]
    [MinLength(3,ErrorMessage = "Minimo {1} caracteres para o campo {0}")]
    public string? Key { get; set; }
    [Required(ErrorMessage = "Informe senha")]
    
    [MinLength(6,ErrorMessage = "Minimo {1} caracteres para o campo {0}")]
    public string? Pass { get; set; }
}