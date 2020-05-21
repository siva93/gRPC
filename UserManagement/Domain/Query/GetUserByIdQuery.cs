namespace User.Domain.Query
{
    using MediatR;
    using User.Domain.ViewModel;
    
    public class GetUserByIdQuery : IRequest<UserDto>
    {
        public int UserId { get; set; }

    }

}