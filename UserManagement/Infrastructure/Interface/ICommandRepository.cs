namespace User.Infrastructure.Interface
{    
    using User.Infrastructure.Entity;
    public interface ICommandRepository 
    {
        UserIdentity AddUserIdentity(UserIdentity userIdentity);
        void DeleteUserIdentity(string userId);
        void UpdateEmail(string userId, string email);

        UserProfile CreateUserProfile(UserProfile userProfile);
        void UpdateUserProfile(UserProfile userProfile);
        
        void UpdateUserRole(string UserId, string role);
    }
}