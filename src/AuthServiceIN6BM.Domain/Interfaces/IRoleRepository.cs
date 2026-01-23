using AuthServiceIN6BM.Domain.Entities;
namespace AuthServiceIN6BM.Domain.Interface;

public interface IRoleRepository
{
    
Task<Role?> GetByNameAsync(string name);
Task<int> CountUsersInRoleAsync(string roleName);
Task<IReadOnlyCollection<User>> GetUsersByRoleAsync(string roleName);
Task<IReadOnlyCollection<string>> GetUserRoleNameAsync(string userId);

}