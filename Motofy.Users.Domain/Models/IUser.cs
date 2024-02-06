﻿
namespace Motofy.Users.Domain.Models
{
    public interface IUser
    {
        Task<User> CreateUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<User> DeleteUserAsync(User user);
    }
}
