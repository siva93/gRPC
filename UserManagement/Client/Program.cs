using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using UserIdentity;
namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var client = new UserIdentity.UserIdentity.UserIdentityClient(channel);
                var addUserIdentityRequest = new AddUserIdentityRequest() { UserName = "b.siva", Email = "b.siva", Password = "*Password*" };
                var reply = await client.AddUserIdentityAsync(addUserIdentityRequest);
                Console.WriteLine($" UserName : {reply.UserName} UserId : {reply.UserId} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
