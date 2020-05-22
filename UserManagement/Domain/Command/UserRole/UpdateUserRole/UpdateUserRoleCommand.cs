namespace User.Domain.Command
{
    using MediatR;
    public class UpdateUserRoleCommand : IRequest
    {
        public string UserId { get; set; }
        public string Role { get; set; }
    }
}