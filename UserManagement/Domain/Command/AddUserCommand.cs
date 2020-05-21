namespace User.Domain.Command
{
    using MediatR;
    using User.Domain.ViewModel;

    public class AddUserCommand : IRequest<AddUserResponseDto>
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}