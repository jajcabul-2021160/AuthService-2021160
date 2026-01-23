using AuthServiceIN6BM.Application.Dtos;
namespace AuthServiceIN6BM.Application.Interfaces;
 
public interface IUserManagementService
{
    Task<UserResponseDto> UpdateUserRoleAsync(string userId, string roleName);
    Task<IReadOnlyList<string>> GetUserRoleAsync(string userId);
    Task<IReadOnlyList<UserResponseDto>> GetUserByRoleAsync(string roleName);
     
}