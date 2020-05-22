
using System;
using System.Collections.Generic;
using System.Linq;
using User.Infrastructure.Context;
using User.Infrastructure.Entity;
using User.Infrastructure.Interface;

namespace User.Infrastructure.Repository
{
    public class CommandRepository : ICommandRepository
    {
        private readonly UserContext _userContext;
        public CommandRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public UserIdentity AddUserIdentity(UserIdentity userIdentity)
        {
            userIdentity.UserId = Guid.NewGuid().ToString();
            _userContext.UserIndentities.Add(userIdentity);
            _userContext.UserRoles.Add(new UserRole(){ UserId = userIdentity.UserId, Role = "User"});
            _userContext.SaveChanges();
            return userIdentity;
        }
        public void DeleteUserIdentity(string userId)
        {
            var currentUserIdentity = _userContext.UserIndentities.FirstOrDefault(a => a.UserId == userId);
            if (currentUserIdentity != null)
            {
                currentUserIdentity.IsActive = false;
                currentUserIdentity.ModifiedAt = DateTime.Now;
                _userContext.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"The given User Id {userId} not found in the system");
            }
        }
        public void UpdateEmail(string userId, string email)
        {
            var currentUserIdentity = _userContext.UserIndentities.FirstOrDefault(a => a.UserId == userId);
            if (currentUserIdentity != null)
            {
                currentUserIdentity.Email = email;
                currentUserIdentity.ModifiedAt = DateTime.Now;
                _userContext.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"The given User Id {userId} not found in the system");
            }
        }

        public UserProfile CreateUserProfile(UserProfile userProfile)
        {
            _userContext.UserProfiles.Add(userProfile);
            _userContext.SaveChanges();
            return userProfile;
        }

        public void UpdateUserProfile(UserProfile userProfile)
        {
            var currentUserProfile = _userContext.UserProfiles.FirstOrDefault(a => a.UserId == userProfile.UserId);
            if (currentUserProfile != null)
            {
                currentUserProfile.FirstName = userProfile.FirstName;
                currentUserProfile.LastName = userProfile.LastName;
                currentUserProfile.Age = userProfile.Age;
                currentUserProfile.Sex = userProfile.Sex;
                currentUserProfile.ModifiedAt = DateTime.Now;
                _userContext.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"The given User Id {userProfile.UserId} not found in the system");
            }
        }

        public void UpdateUserRole(string userId, string role)
        {
            var currentUserRole = _userContext.UserRoles.FirstOrDefault(a => a.UserId == userId);
            if (currentUserRole != null)
            {
                currentUserRole.Role = role;
                currentUserRole.ModifiedAt = DateTime.Now;
                _userContext.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"The given User Id {userId} not found in the system");
            }
        }
    }
}