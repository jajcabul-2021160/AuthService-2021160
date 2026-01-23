using System.ComponentModel.DataAnnotations;
namespace AuthServiceIN6BM.Application.Dtos.Email;

public class VerifyEmailDto
{
    
[Required]
public string Token { get; set;} = string.Empty;

}