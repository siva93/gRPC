using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using User.Domain.ViewModel;
using User.Infrastructure.Interface;
using User.Infrastructure.Entity;

namespace User.Domain.Command
{
    public class AddUserIdentityCommandHandler : IRequestHandler<AddUserIdentityCommand, UserIdentityDTO>
    {
        private readonly ICommandRepository _commandRepository;
        private readonly IMapper _mapper;
        public AddUserIdentityCommandHandler(ICommandRepository commandRepository, IMapper mapper)
        {
            _commandRepository = commandRepository;
            _mapper = mapper;
        }
        public Task<UserIdentityDTO> Handle(AddUserIdentityCommand request, CancellationToken cancellationToken)
        {
            var entity = new UserIdentity() { Email = request.Email, UserName = request.UserName, Password = request.Password};
            var response = _commandRepository.AddUserIdentity(entity);
            return Task.FromResult(new UserIdentityDTO(response));
        }
    }
}