namespace User.Domain.Command
{
    using MediatR;
    using User.Domain.ViewModel;

    public class CreateUserProfileCommand : IRequest<UserProfileDTO>
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
    }
}