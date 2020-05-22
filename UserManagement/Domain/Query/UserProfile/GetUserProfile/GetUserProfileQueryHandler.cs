using System.Threading;
using System.Threading.Tasks;
using MediatR;
using User.Infrastructure.Interface;
using User.Domain.ViewModel;

namespace User.Domain.Query
{
    public class GetUserProfileQueryHandler : IRequestHandler<GetUserProfileQuery, UserProfileDTO>
    {
        private readonly IQueryRepository _queryRepository;
        public GetUserProfileQueryHandler(IQueryRepository queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public Task<UserProfileDTO> Handle(GetUserProfileQuery request, CancellationToken cancellationToken)
        {
            var response = _queryRepository.GetUserProfile(request.UserId);
            return Task.FromResult(new UserProfileDTO(response));
        }
    }
}