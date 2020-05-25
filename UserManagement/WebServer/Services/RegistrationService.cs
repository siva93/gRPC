using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using DomainContract.ServiceContract;
using DomainContract.DataContract;
using ProtoBuf.Grpc;
using MediatR;

namespace WebServer
{
    public class RegistrationService : IRegisterServiceContract
    {
        private readonly ILogger<RegistrationService> _logger;
        private readonly IMediator _mediator;
        public RegistrationService(ILogger<RegistrationService> logger,IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public Task<RegisterResponse> RegistrationAsync(RegisterRequest request)
        {
            return _mediator.Send(request);
        }
    }
}
