using MediatR;
using User.Domain.ViewModel;

namespace User.Domain.Query
{
    public class GetUserRoleQuery : IRequest<UserRoleDTO>
    {
        public string UserId {get;set;}
        public string Role {get;set;}
    }
}