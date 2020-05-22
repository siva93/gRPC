using User.Infrastructure.Entity;

namespace User.Domain.ViewModel
{
    public class UserRoleDTO
    {
        public UserRoleDTO(UserRole role)
        {
            this.UserId = role.UserId;
            this.Role = role.Role;
        }
        public string UserId {get;set;}
        public string Role {get;set;}
        
    }
}