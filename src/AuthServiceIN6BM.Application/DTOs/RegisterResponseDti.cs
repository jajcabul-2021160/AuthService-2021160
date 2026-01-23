namespace AuthServiceIN6BM.Application.Dtos;


public class RegisterResponseDto
{
    


    public bool Sucess { get; set;} = false;
    public UserResponseDto User { get; set;} = new();
    public string Message { get; set;} = string.Empty;
    public bool IsEmailVerificationRequired { get; set;} = true;
}