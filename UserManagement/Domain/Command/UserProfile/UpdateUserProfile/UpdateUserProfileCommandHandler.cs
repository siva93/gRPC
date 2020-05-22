using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using User.Infrastructure.Interface;
using User.Infrastructure.Entity;

namespace User.Domain.Command
{
    public class UpdateUserProfileCommandHandler : IRequestHandler<UpdateUserProfileCommand>
    {
        private readonly ICommandRepository _commandRepository;
        private readonly IMapper _mapper;
        public UpdateUserProfileCommandHandler(ICommandRepository commandRepository, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(UpdateUserProfileCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<UserProfile>(request);
            _commandRepository.UpdateUserProfile(entity);
            return Task.FromResult(new Unit());
        }
    }
}