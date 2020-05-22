using System.Threading;
using System.Threading.Tasks;
using MediatR;
using User.Infrastructure.Interface;
using User.Infrastructure.Entity;

namespace User.Domain.Command
{
    public class UpdateUserProfileCommandHandler : IRequestHandler<UpdateUserProfileCommand>
    {
        private readonly ICommandRepository _commandRepository;
        public UpdateUserProfileCommandHandler(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }

        public Task<Unit> Handle(UpdateUserProfileCommand request, CancellationToken cancellationToken)
        {
            var entity =new UserProfile(){ FirstName = request.FirstName, LastName = request.LastName, Age = request.Age, Sex = request.Sex };
            _commandRepository.UpdateUserProfile(entity);
            return Task.FromResult(new Unit());
        }
    }
}