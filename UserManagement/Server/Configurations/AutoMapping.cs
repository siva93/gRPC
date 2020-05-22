namespace User.Server.Configurations
{
    using AutoMapper;
    using UserIdentity;
    using UserProfile;
    using UserRole;
    using User.Domain.Query;
    using User.Domain.Command;
    using User.Domain.ViewModel;
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            //gRPC request to Query model
            CreateMap<GetUserProfileRequest, GetUserProfileQuery>();
            CreateMap<GetUserIdentityRequest, GetUserIdentityQuery>();
            CreateMap<GetUserRoleRequest, GetUserRoleQuery>();
            
            //gRPC request to Command model
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
            CreateMap<UserProfileDTO,UserProfileResponse>();
            CreateMap<UserRoleResponse, UserRoleDTO>();
            CreateMap<UserRoleDTO, UserRoleResponse>();
        }
    }
}