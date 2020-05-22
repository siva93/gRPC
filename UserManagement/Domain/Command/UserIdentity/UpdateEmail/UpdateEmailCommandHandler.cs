using System.Threading;
using System.Threading.Tasks;
using MediatR;
using User.Infrastructure.Interface;

namespace User.Domain.Command
{
    public class UpdateEmailCommandHandler : IRequestHandler<UpdateEmailCommand>
    {
        private readonly ICommandRepository _commandRepository;
        public UpdateEmailCommandHandler(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }

        public Task<Unit> Handle(UpdateEmailCommand request, CancellationToken cancellationToken)
        {
            _commandRepository.UpdateEmail(request.UserId, request.Email);
             return  Task.FromResult(new Unit());
        }
    }
}