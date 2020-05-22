namespace User.Infrastructure.Entity
{
    using System;
    public class UserIdentity
    {
        public UserIdentity()
        {
            CreatedAt = ModifiedAt = DateTime.Now;
            IsActive = true;
        }
        public string UserId { get; set; }       
        public string  UserName { get; set; }
        public string  Email { get; set; }
        public string  Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }     
        public DateTime ModifiedAt { get; set; }     
    }
}