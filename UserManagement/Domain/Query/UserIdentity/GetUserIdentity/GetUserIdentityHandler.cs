using System.Threading;
using System.Threading.Tasks;
using MediatR;
using User.Domain.ViewModel;
using User.Infrastructure.Interface;

namespace User.Domain.Query
{
    public class GetUserIdentityHandler : IRequestHandler<GetUserIdentityQuery, UserIdentityDTO>
    {
        private readonly IQueryRepository _queryRepository;
        public GetUserIdentityHandler(IQueryRepository queryRepository)
        {
            _queryRepository = queryRepository;
        }
        public Task<UserIdentityDTO> Handle(GetUserIdentityQuery request, CancellationToken cancellationToken)
        {
            var response = _queryRepository.GetUserIdentity(request.UserId);
            return Task.FromResult(new UserIdentityDTO(response));
        }
    }
}