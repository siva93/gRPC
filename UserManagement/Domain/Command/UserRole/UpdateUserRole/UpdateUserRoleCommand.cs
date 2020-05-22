namespace User.Domain.Command
{
    using MediatR;
    public class UpdateUserRoleCommand : IRequest
    {
        public string UserName { get; set; }
        public string Role { get; set; }
    }
}