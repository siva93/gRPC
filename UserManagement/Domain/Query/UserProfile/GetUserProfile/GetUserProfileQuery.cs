
namespace User.Domain.Query
{
    using MediatR;
    using User.Domain.ViewModel;

    public class GetUserProfileQuery : IRequest<UserProfileDTO>
    {
        public string UserId { get; set; }
    }
}