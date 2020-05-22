using System.Threading;
using System.Threading.Tasks;
using MediatR;
using User.Infrastructure.Interface;
using User.Domain.ViewModel;
using User.Infrastructure.Entity;

namespace User.Domain.Command
{
    public class CreateUserProfileCommandHandler : IRequestHandler<CreateUserProfileCommand, UserProfileDTO>
    {
        private readonly ICommandRepository _commandRepository;
        public CreateUserProfileCommandHandler(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }

        public Task<UserProfileDTO> Handle(CreateUserProfileCommand request, CancellationToken cancellationToken)
        {
            var entity =new UserProfile(){ FirstName = request.FirstName, LastName = request.LastName, Age = request.Age, Sex = request.Sex };
            var response = _commandRepository.CreateUserProfile(entity);
            return Task.FromResult(new UserProfileDTO(response));
        }
    }
}