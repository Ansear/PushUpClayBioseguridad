using Domain.Entities;

namespace Domain.Interfaces;
public interface IUser : IGenericRepository<User>
{
    Task<User> GetByUsernameAsync(string username);
    Task<User> GetByUserEmailAsync(string email);
    Task<User> GetByRefreshTokenAsync(string username);
}