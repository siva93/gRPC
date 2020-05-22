namespace User.Server.Configurations
{
    using AutoMapper;
    using UserIdentity;
    using UserProfile;
    using UserRole;
    using User.Domain.Query;
    using User.Domain.Command;
    using User.Domain.ViewModel;
    using User.Infrastructure.Entity;
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            //gRPC request tp Command/Query model
            //Query
            CreateMap<GetUserProfileRequest, GetUserProfileQuery>();
            CreateMap<GetUserIdentityRequest, GetUserIdentityQuery>();
            CreateMap<GetUserRoleRequest, GetUserRoleQuery>();
            
            //Command
            CreateMap<AddUserIdentityRequest, AddUserIdentityCommand>();
            CreateMap<UpdateEmailRequest, UpdateEmailCommand>();
            CreateMap<DeleteUserIdentityRequest, DeleteUserIdentityCommand>();
            CreateMap<CreateUserProfileRequest, CreateUserProfileCommand>();
            CreateMap<UpdateUserProfileRequest, UpdateUserProfileCommand>();
            CreateMap<UpdateUserRoleRequest, UpdateUserRoleCommand>();        

            //DTO
            CreateMap<UserIdentityResponse, UserIdentityDTO>();
            CreateMap<UserIdentityDTO,  UserIdentityResponse>();
            CreateMap<UserProfileResponse, UserProfileDTO>();
            CreateMap<UserRoleResponse, UserRoleDTO>();

            //Entity
            CreateMap<User.Infrastructure.Entity.UserIdentity, AddUserIdentityCommand>();
            CreateMap<User.Infrastructure.Entity.UserProfile, CreateUserProfileCommand>();
            CreateMap<User.Infrastructure.Entity.UserProfile, UpdateUserProfileCommand>();
        }
    }
}