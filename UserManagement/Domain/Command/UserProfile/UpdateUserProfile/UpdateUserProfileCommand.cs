namespace User.Domain.Command
{
    using MediatR;
    public class UpdateUserProfileCommand : IRequest
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
    }
}