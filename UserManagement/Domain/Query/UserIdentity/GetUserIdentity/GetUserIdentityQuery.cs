using MediatR;
using User.Domain.ViewModel;

namespace User.Domain.Query
{
    public class GetUserIdentityQuery : IRequest<UserIdentityDTO>
    {
        public string UserId {get;set;}
    }
}