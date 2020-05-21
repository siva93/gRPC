namespace User.Server.Configurations
{
    using AutoMapper;
    using UserProfile;
    using User.Domain.Query;
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<GetUserProfileRequest, GetUserProfileQuery>();
        }
    }
}