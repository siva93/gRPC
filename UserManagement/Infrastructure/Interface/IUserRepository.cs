namespace User.Infrastructure.Interface
{
    
    using User.Infrastructure.Entity;
    using System.Collections.Generic;
    public interface IUserRepository 
    {
        User Get(int id);
        List<User> GetList();
        User Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}