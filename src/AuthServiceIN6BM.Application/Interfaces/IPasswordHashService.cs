
 
namespace AuthServiceIN6BM.Application.Interfaces;
 
public interface IPasswordHashServic
{
    string HashPassword(string password);
    bool VerifyPassword(string password, string hashedPassword);
}