using User.Infrastructure.Entity;

namespace User.Domain.ViewModel
{
    public class UserIdentityDTO
    {
        public UserIdentityDTO(UserIdentity userIdentity)
        {
            this.UserId = userIdentity.UserId;
            this.Email = userIdentity.Email;
            this.UserName = userIdentity.UserName;
        }
        public string UserId { get; set; }       
        public string  UserName { get; set; }
        public string  Email { get; set; }
        
    }
}