using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace CreditRatingService
{
    public class CreditRatingService : CreditRatingCheck.CreditRatingCheckBase
    {
        private readonly ILogger<CreditRatingService> _logger;

        private static readonly Dictionary<string, Int32> customerCredit = new Dictionary<string, Int32>(){
            {"cr001", 1000},
            {"cr002", 5000},
            {"cr003", 8000}

        };

        public CreditRatingService(ILogger<CreditRatingService> logger)
        {
            _logger = logger;
        }

        public override Task<CreditResponse> CheckCreditRequest(CreditRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CreditResponse
            {
                IsAccepted = IsCreditElegible(request.CustomerId, request.Credit)
            });
        }

        public override async Task<CounterReply> CounterStream(IAsyncStreamReader<CounterRequest> request, ServerCallContext context)
        {
            Int32 count = 0;
            await foreach( var message in request.ReadAllAsync())
            {
                count += message.Count;
            }
            return new CounterReply {Total = count };
        }
        private bool IsCreditElegible(string customerId, Int32 credit)
        {
            bool isAccepted = false;
            if(customerCredit.TryGetValue(customerId, out Int32 maxCredit))
            {
                isAccepted = credit <= maxCredit;
            }
            return isAccepted;
        }
    }
}
