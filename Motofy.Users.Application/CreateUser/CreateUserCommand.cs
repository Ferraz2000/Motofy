using Motofy.Users.Application.Abstractions;

namespace Motofy.Users.Application.CreateUser
{
    public sealed record CreateUserCommand
        (
            string Name,
            string Email,
            string Password,
            DateOnly BirthDate
        ): ICommand<Guid>;
}