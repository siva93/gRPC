using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using User.Infrastructure.Interface;

namespace User.Domain.Command
{
    public class DeleteUserIdentityCommandHandler : IRequestHandler<DeleteUserIdentityCommand>
    {
        private readonly ICommandRepository _commandRepository;
        public DeleteUserIdentityCommandHandler(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }

        public Task<Unit> Handle(DeleteUserIdentityCommand request, CancellationToken cancellationToken)
        {
             _commandRepository.DeleteUserIdentity(request.UserId);
             return  Task.FromResult(new Unit());
        }
    }
}