using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using User.Infrastructure.Interface;
using User.Domain.ViewModel;

namespace User.Domain.Query
{
    public class GetUserProfileQueryHandler : IRequestHandler<GetUserProfileQuery, UserProfileDTO>
    {
        private readonly IQueryRepository _queryRepository;
        private readonly IMapper _mapper;
        public GetUserProfileQueryHandler(IQueryRepository queryRepository, IMapper mapper)
        {
            _queryRepository = queryRepository;
            _mapper = mapper;
        }

        public Task<UserProfileDTO> Handle(GetUserProfileQuery request, CancellationToken cancellationToken)
        {
            var response = _queryRepository.GetUserProfile(request.UserId);
            return Task.FromResult(_mapper.Map<UserProfileDTO>(response));
        }
    }
}