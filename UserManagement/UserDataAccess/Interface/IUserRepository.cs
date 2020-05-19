namespace user_data_access
{
    using System;
    using user_domain;
    using System.Collections;
    using System.Collections.Generic;
    public interface IUserRepository 
    {
        User Get(int id);
        List<User> GetList();
        void Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}