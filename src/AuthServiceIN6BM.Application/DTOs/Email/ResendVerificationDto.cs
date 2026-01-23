using System.ComponentModel.DataAnnotations;
namespace AuthServiceIN6BM.Application.Dtos.Email;


public class ResendVerificationDto
{
    
[Required]
[EmailAddress]
public string Email { get; set;} = string.Empty;


}