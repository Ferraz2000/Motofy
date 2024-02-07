namespace Motofy.Users.Domain.Models.User
{
    public interface IUser
    {
        Task<User> CreateUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task DeleteUserAsync(Guid id);
    }
}
