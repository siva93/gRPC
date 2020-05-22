namespace User.Infrastructure.Interface
{
    
    using User.Infrastructure.Entity;
    using System.Collections.Generic;
    public interface IQueryRepository 
    {
        UserIdentity GetUserIdentity(string UserId);
        UserProfile GetUserProfile(string UserId);
        UserRole GetUserRole(string UserId);
    }
}