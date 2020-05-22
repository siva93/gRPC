using System.Threading;
using System.Threading.Tasks;
using MediatR;
using User.Infrastructure.Interface;
using User.Domain.ViewModel;

namespace User.Domain.Query
{
    public class GetUserRoleQueryHandler : IRequestHandler<GetUserRoleQuery, UserRoleDTO>
    {
        private readonly IQueryRepository _queryRepository;
        public GetUserRoleQueryHandler(IQueryRepository queryRepository)
        {
            _queryRepository = queryRepository;        
        }

        public Task<UserRoleDTO> Handle(GetUserRoleQuery request, CancellationToken cancellationToken)
        {
             var response = _queryRepository.GetUserRole(request.UserId);
            return Task.FromResult(new UserRoleDTO(response));
        }
    }
}