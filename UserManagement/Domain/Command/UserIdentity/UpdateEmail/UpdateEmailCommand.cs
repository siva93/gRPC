namespace User.Domain.Command
{
    using MediatR;
    public class UpdateEmailCommand : IRequest
    {
        public string UserId { get; set; }
        public string Email { get; set; }
    }
}