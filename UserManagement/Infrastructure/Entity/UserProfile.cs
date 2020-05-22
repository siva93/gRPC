namespace User.Infrastructure.Entity
{
    using System;
    public class UserProfile 
    {
        public UserProfile()
        {
            CreatedAt = ModifiedAt = DateTime.Now;
            IsActive = true;
        }
        public string UserId { get; set; }       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Sex { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }     
        public DateTime ModifiedAt { get; set; }     
    }
}