using MediatR;
using Motofy.Users.Domain.Models.Abstractions;

namespace Motofy.Users.Application.Abstractions
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result> where TCommand : ICommand
    { }


    public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>> where TCommand : ICommand<TResponse>
    {

    }

}
