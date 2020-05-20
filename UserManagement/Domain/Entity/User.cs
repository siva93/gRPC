namespace User.Domain.Entity
{
    using System;
    public class User 
    {
        public User()
        {
            CreatedAt = ModifiedAt = DateTime.Now;
            IsActive = true;
        }
        public int Id { get; set; }       
        public string Name { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }     
        public DateTime ModifiedAt { get; set; }     
    }
}