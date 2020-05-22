using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using User.Infrastructure.Interface;

namespace User.Domain.Command
{
    public class UpdateUserRoleCommandHandler : IRequestHandler<UpdateUserRoleCommand>
    {
        private readonly ICommandRepository _commandRepository;
        private readonly IMapper _mapper;
        public UpdateUserRoleCommandHandler(ICommandRepository commandRepository, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(UpdateUserRoleCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}