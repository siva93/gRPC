using System;
using System.Threading.Tasks;
using UserServiceProto;
using Grpc.Net.Client;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try{
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new UserService.UserServiceClient(channel);
            var addRequest = new AddUserRequest() { UserName = "abc", Name = "Siva", Age = 26 };
            var reply = await client.AddUserAsync(addRequest);
            Console.WriteLine($" UserName : {reply.UserName} UserId : {reply.UserId} ");            
            var getRequest = new GetUserRequest { UserId = reply.UserId };
            var getReply = await client.GetUserAsync(getRequest);

            Console.WriteLine($" UserName : {getReply.User.UserName} UserId : {getReply.User.UserId} IsActive : {getReply.User.IsActive} ");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);    
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
