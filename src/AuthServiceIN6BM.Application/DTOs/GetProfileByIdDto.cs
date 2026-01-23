using System.ComponentModel.DataAnnotations;

namespace AuthServiceIN6BM.Application.Dtos;


public class GetProfileByIdDto
{
    
    [Required(ErrorMessage = "El userId es requerido")]
    public string UserId { get; set;} = string.Empty;
}