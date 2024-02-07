using Motofy.Users.Application.Abstractions;
using Motofy.Users.Domain.Models.Abstractions;
using Motofy.Users.Domain.Models.User;

namespace Motofy.Users.Application.DeleteUser
{
    internal sealed class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
    {
        private readonly IUser userRepository;
        public DeleteUserCommandHandler(IUser _userRepository)
        {
            userRepository = _userRepository;
        }
        public async Task<Result> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            await userRepository.DeleteUserAsync(request.id);

            return Result.Success();
        }
    }
}
