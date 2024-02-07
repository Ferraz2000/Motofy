using MediatR;
using Motofy.Users.Domain.Models.Abstractions;

namespace Motofy.Users.Application.Abstractions.Messaging
{
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>> where TQuery : IQuery<TResponse>
    {
    }
}
