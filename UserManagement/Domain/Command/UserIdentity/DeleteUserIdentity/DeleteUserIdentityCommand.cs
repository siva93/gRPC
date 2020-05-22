namespace User.Domain.Command
{
    using MediatR;
    public class DeleteUserIdentityCommand : IRequest
    {
        public string UserId { get; set; }
    }
}