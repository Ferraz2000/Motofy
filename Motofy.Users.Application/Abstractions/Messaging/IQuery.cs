using MediatR;
using Motofy.Users.Domain.Models.Abstractions;

namespace Motofy.Users.Application.Abstractions.Messaging
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
