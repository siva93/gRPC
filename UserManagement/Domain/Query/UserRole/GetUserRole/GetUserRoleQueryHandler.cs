using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using User.Infrastructure.Interface;
using User.Domain.ViewModel;

namespace User.Domain.Query
{
    public class GetUserRoleQueryHandler : IRequestHandler<GetUserRoleQuery, UserRoleDTO>
    {
        private readonly IQueryRepository _queryRepository;
        private readonly IMapper _mapper;
        public GetUserRoleQueryHandler(IQueryRepository queryRepository, IMapper mapper)
        {
            _queryRepository = queryRepository;
            _mapper = mapper;
        }

        public Task<UserRoleDTO> Handle(GetUserRoleQuery request, CancellationToken cancellationToken)
        {
             var response = _queryRepository.GetUserRole(request.UserId);
            return Task.FromResult(_mapper.Map<UserRoleDTO>(response));
        }
    }
}