namespace User.Domain.Command
{
    using MediatR;
    using User.Domain.ViewModel;

    public class AddUserIdentityCommand : IRequest<UserIdentityDTO>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}