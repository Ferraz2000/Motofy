using MediatR;
using Motofy.Users.Domain.Models.Abstractions;

namespace Motofy.Users.Application.Abstractions
{
    public interface ICommand : IRequest<Result>, IBaseCommand
    {
    }

    public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand
    {
    }

    public interface IBaseCommand
    {

    }

}