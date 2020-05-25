namespace DomainContract.ServiceContract
{
    using System.ServiceModel;
    using System.Threading.Tasks;
    using ProtoBuf.Grpc;
    using ProtoBuf.Grpc.Configuration;
    using DomainContract.DataContract;

    [ServiceContract(Name = "User.Registration")]
    public interface IRegisterServiceContract
    {
        [Operation]
        Task<RegisterResponse> RegistrationAsync(RegisterRequest request);
    }
}