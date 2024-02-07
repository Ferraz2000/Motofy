using Motofy.Users.Application.Abstractions;

namespace Motofy.Users.Application.DeleteUser
{
    public sealed record DeleteUserCommand(Guid id) : ICommand;

}
