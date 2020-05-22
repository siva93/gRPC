using System.Threading;
using System.Threading.Tasks;
using MediatR;
using User.Infrastructure.Interface;

namespace User.Domain.Command
{
    public class UpdateUserRoleCommandHandler : IRequestHandler<UpdateUserRoleCommand>
    {
        private readonly ICommandRepository _commandRepository;
        public UpdateUserRoleCommandHandler(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }

        public Task<Unit> Handle(UpdateUserRoleCommand request, CancellationToken cancellationToken)
        {
            _commandRepository.UpdateUserRole(request.UserId, request.Role);
            return Task.FromResult(new Unit());
        }
    }
}