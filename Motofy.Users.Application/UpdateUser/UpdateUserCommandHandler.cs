using Motofy.Users.Application.Abstractions;
using Motofy.Users.Domain.Models.Abstractions;
using Motofy.Users.Domain.Models.User;

namespace Motofy.Users.Application.UpdateUser
{
    internal sealed class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand, User>
    {
        private readonly IUser userRepository;
        public UpdateUserCommandHandler(IUser _userRepository)
        {

            userRepository = _userRepository;

        }
        public async Task<Result<User>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var result = await userRepository.UpdateUserAsync(request.user);

            return Result.Success(result);
        }
    }
}
