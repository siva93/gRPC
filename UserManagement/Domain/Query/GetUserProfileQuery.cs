using MediatR;
using User.Domain.ViewModel;

namespace User.Domain.Query
{
    public class GetUserProfileQuery : IRequest<UserProfileDTO>
    {
        public string UserName {get;set;}
    }
}