using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using CreditRatingService;
namespace CreditRatingClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new CreditRatingCheck.CreditRatingCheckClient(channel);
            var creditRequest = new CreditRequest { CustomerId = "cr001", Credit = 4000 };
            var reply = await client.CheckCreditRequestAsync(creditRequest);
            Console.WriteLine($"Credit for customer {creditRequest.CustomerId} {(reply.IsAccepted ? "approved" : "rejected")}!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
