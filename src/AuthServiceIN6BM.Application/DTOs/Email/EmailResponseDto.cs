namespace AuthServiceIN6BM.Application.Dtos.Email;

public class EmailResponseDto
{
    

public bool Sucess { get; set;}
public string Message { get; set;} = string.Empty;
public object? Data { get; set;}

}