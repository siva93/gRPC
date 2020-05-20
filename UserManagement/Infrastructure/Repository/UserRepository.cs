namespace User.Infrastructure.Repository
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using User.Domain.Entity;
    using User.Infrastructure.Interface;
    using User.Infrastructure.Context;
    using Microsoft.EntityFrameworkCore;

    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext;
        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public User Get(int id)
        {
            var currentUser = _userContext.Users.AsNoTracking().FirstOrDefault(a=> a.Id == id);
            if(currentUser != null)
            {
                return currentUser;
            }
            else
            {
                throw new KeyNotFoundException($"The given User Id {id} not found in the system");
            }
        }

        public List<User> GetList()
        {
            return _userContext.Users.AsNoTracking().ToList();
        }

        public void Add(User user)
        {
            _userContext.Add(user);
            _userContext.SaveChanges();
        }
        public void Update(User user)
        {
            var currentUser = _userContext.Users.FirstOrDefault(a=> a.Id == user.Id);
            if(currentUser != null)
            {
                currentUser.Name = user.Name;
                currentUser.UserName = user.UserName;
                currentUser.Age = user.Age;
                currentUser.IsActive = user.IsActive;
                currentUser.ModifiedAt = DateTime.Now;
                _userContext.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"The given User Id {user.Id} not found in the system");
            }
        }
        public void Delete(int id)
        {
            var currentUser = _userContext.Users.FirstOrDefault(a=> a.Id == id);
            if(currentUser != null)
            {
                currentUser.IsActive = false;
                currentUser.ModifiedAt = DateTime.Now;                
                _userContext.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"The given User Id {id} not found in the system");
            }
        }
    }
}