using Motofy.Users.Application.Abstractions;
using Motofy.Users.Domain.Models.Abstractions;
using Motofy.Users.Domain.Models.User;

namespace Motofy.Users.Application.CreateUser
{
    internal sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, Guid>
    {
        private readonly IUser _user;

        public CreateUserCommandHandler(IUser user)
        {
            _user = user;
        }

        public async Task<Result<Guid>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            //TODO: if cnh
            var user = User.CreateUser(
                    new Email(request.Email),
                    new Name(request.Name),
                    BirthDate.Create(request.BirthDate));

            var createUser = await _user.CreateUserAsync(user);
            return createUser.Id;

        }
    }
}
