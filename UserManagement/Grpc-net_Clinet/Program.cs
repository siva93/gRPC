using System;
using Grpc.Core;
using Grpc.Net.Client;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Client;
using System.Threading;
using System.Threading.Tasks;
using DomainContract.ServiceContract;
using DomainContract.DataContract;

namespace Grpc_net_Clinet
{
    class Program
    {
        static async Task Main(string[] args)
        {
            GrpcClientFactory.AllowUnencryptedHttp2 = true;
            using var http = GrpcChannel.ForAddress("https://localhost:5001");
            var registration = http.CreateGrpcService<IRegisterServiceContract>();
            var result = await registration.RegistrationAsync(new RegisterRequest(){ FirstName = "s", LastName = "b", Age = 23, Email = "s", Sex = "M" });
            Console.WriteLine($"{result.UserId}");
            Console.ReadKey();
        }
    }
}
