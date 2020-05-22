using System.Threading;
using System.Threading.Tasks;
using MediatR;
using User.Domain.ViewModel;
using User.Infrastructure.Interface;
using User.Infrastructure.Entity;

namespace User.Domain.Command
{
    public class AddUserIdentityCommandHandler : IRequestHandler<AddUserIdentityCommand, UserIdentityDTO>
    {
        private readonly ICommandRepository _commandRepository;
        public AddUserIdentityCommandHandler(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }
        public Task<UserIdentityDTO> Handle(AddUserIdentityCommand request, CancellationToken cancellationToken)
        {
            var entity = new UserIdentity() { Email = request.Email, UserName = request.UserName, Password = request.Password};
            var response = _commandRepository.AddUserIdentity(entity);
            return Task.FromResult(new UserIdentityDTO(response));
        }
    }
}