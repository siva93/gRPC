namespace User.Infrastructure.Entity
{
    using System;
    public class UserRole 
    {
        public UserRole()
        {
            CreatedAt = ModifiedAt = DateTime.Now;
            IsActive = true;
        }
        public string UserId { get; set; }       
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }     
        public DateTime ModifiedAt { get; set; }     
    }
}