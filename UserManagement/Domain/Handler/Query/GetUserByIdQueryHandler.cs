using System.Threading;
using System.Threading.Tasks;
using MediatR;
using User.Domain.Query;
using User.Domain.ViewModel;
using User.Infrastructure.Interface;

namespace User.Domain.Handler.Query
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDto>
    {
        public readonly IUserRepository _userRepository;
        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = _userRepository.Get(request.UserId);
            return Task.FromResult(new UserDto()
            { 
                UserId = user.Id, 
                UserName = user.UserName,
                Age = user.Age,
                IsActive = user.IsActive
            });
        }
    }
}