using AuthServiceIN6BM.Application.Dtos;
using AuthServiceIN6BM.Application.Dtos.Email;
 
namespace AuthServiceIN6BM.Application.Interfaces;
public interface IAuthService
{
    Task<RegisterResponseDto> RegisterAsync(RegisterDto registerDto);
    Task<AuthResponseDto> LoginAsync(LoginDto loginDto);
    Task<EmailResponseDto> VerifyEmailAsync(VerifyEmailDto verifyEmailDto);
    Task<EmailResponseDto> ResendVerificationEmailAsync(ResendVerificationDto resendDTO);
    Task<EmailResponseDto> ForgotPasswordAsync(ResetPasswordDto forgotPasswordDto);
    Task<EmailResponseDto> ResetPasswordAsync(ResetPasswordDto resetPasswordDto);
    Task<UserResponseDto> GetUserByIdAsync(string userId);
 
 
}