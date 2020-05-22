namespace User.Infrastructure.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using User.Infrastructure.Context;
    using User.Infrastructure.Entity;
    using User.Infrastructure.Interface;

    public class QueryRepository : IQueryRepository
    {
        private readonly UserContext _userContext;
        public QueryRepository(UserContext userContext)
        {
            _userContext = userContext;
        }
        public UserIdentity GetUserIdentity(string userId)
        {
            var userIdentity = _userContext.UserIndentities.AsNoTracking().FirstOrDefault(a=> a.UserId == userId);
            if(userIdentity != null)
            {
                return userIdentity;
            }
            else
            {
                throw new KeyNotFoundException($"The given User Id {userId} not found in the system");
            }
        }

        public UserProfile GetUserProfile(string userId)
        {
            var userProfile = _userContext.UserProfiles.AsNoTracking().FirstOrDefault(a=> a.UserId == userId);
            if(userProfile != null)
            {
                return userProfile;
            }
            else
            {
                throw new KeyNotFoundException($"The given User Id {userId} not found in the system");
            }
        }

        public UserRole GetUserRole(string userId)
        {
            var userRole = _userContext.UserRoles.AsNoTracking().FirstOrDefault(a=> a.UserId == userId);
            if(userRole != null)
            {
                return userRole;
            }
            else
            {
                throw new KeyNotFoundException($"The given User Id {userId} not found in the system");
            }
        }
    }
}