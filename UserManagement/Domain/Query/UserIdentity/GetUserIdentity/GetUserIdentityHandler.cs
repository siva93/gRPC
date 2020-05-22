using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using User.Domain.Query;
using User.Domain.ViewModel;
using User.Infrastructure.Interface;

namespace User.Domain.Query
{
    public class GetUserIdentityHandler : IRequestHandler<GetUserIdentityQuery, UserIdentityDTO>
    {
        private readonly IQueryRepository _queryRepository;
        private readonly IMapper _mapper;
        public GetUserIdentityHandler(IQueryRepository queryRepository, IMapper mapper)
        {
            _queryRepository = queryRepository;
            _mapper = mapper;
        }
        public Task<UserIdentityDTO> Handle(GetUserIdentityQuery request, CancellationToken cancellationToken)
        {
            var response = _queryRepository.GetUserIdentity(request.UserId);
            return Task.FromResult(_mapper.Map<UserIdentityDTO>(response));
        }
    }
}