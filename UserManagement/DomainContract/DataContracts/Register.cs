using MediatR;
using ProtoBuf;
namespace DomainContract.DataContract
{
    [ProtoContract]
    public class RegisterRequest : IRequest<RegisterResponse>
    {
        [ProtoMember(1)]
        public string FirstName { get; set; }
        
        [ProtoMember(2)]
        public string LastName { get; set; }
        
        [ProtoMember(3)]
        public string Email { get; set; }
        
        [ProtoMember(4)]
        public  int Age { get; set; }
        
        [ProtoMember(5)]
        public string Sex { get; set; }
    }
    
    [ProtoContract]
    public class RegisterResponse
    {
        [ProtoMember(1)]
        public string UserId { get; set; }
    }
}