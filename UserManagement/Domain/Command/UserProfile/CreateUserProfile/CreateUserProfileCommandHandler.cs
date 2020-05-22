using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using User.Infrastructure.Interface;
using User.Domain.ViewModel;
using User.Infrastructure.Entity;

namespace User.Domain.Command
{
    public class CreateUserProfileCommandHandler : IRequestHandler<CreateUserProfileCommand, UserProfileDTO>
    {
        private readonly ICommandRepository _commandRepository;
        private readonly IMapper _mapper;
        public CreateUserProfileCommandHandler(ICommandRepository commandRepository, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _mapper = mapper;
        }

        public Task<UserProfileDTO> Handle(CreateUserProfileCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<UserProfile>(request);
            var response = _commandRepository.CreateUserProfile(entity);
            return Task.FromResult(_mapper.Map<UserProfileDTO>(response));
        }
    }
}