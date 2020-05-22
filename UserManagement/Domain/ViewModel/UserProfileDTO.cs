using User.Infrastructure.Entity;

namespace User.Domain.ViewModel
{
    public class UserProfileDTO
    {
        public UserProfileDTO(UserProfile profile)
        {
            this.FirstName = profile.FirstName;
            this.LastName = profile.LastName;
            this.Age = profile.Age;
            this.Sex = profile.Sex;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
    }
}