using System.Threading;
using System.Threading.Tasks;
using MediatR;
using User.Domain.Command;
using User.Domain.ViewModel;
using User.Infrastructure.Interface;
using User.Infrastructure.Entity;

namespace User.Domain.Handler.Command
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, ViewModel.AddUserResponseDto>
    {
        private readonly IUserRepository _userRepository;
        public AddUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<AddUserResponseDto> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var response = _userRepository.Add(new Infrastructure.Entity.User() { UserName = request.UserName, Name = request.Name, Age = request.Age});
            return Task.FromResult(new AddUserResponseDto(){ UserId = response.Id, UserName = response.UserName});
        }
    }
}