using Motofy.Users.Application.Abstractions;
using Motofy.Users.Domain.Models.User;

namespace Motofy.Users.Application.UpdateUser
{
    public sealed record UpdateUserCommand(User user) : ICommand<User>;

}
