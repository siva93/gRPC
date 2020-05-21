namespace User.Server.Services
{
    using UserIdentity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Grpc.Core;
    using MediatR;
    using Microsoft.Extensions.Logging;
    using User.Domain.Command;
    using User.Domain.Query;
    using AutoMapper;
    public class UserIdentityManagementService : UserIdentity.UserIdentityBase
    {
        private readonly ILogger<UserIdentityManagementService> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UserIdentityManagementService(ILogger<UserIdentityManagementService> logger, IMapper mapper, IMediator mediator)
        {
            _logger = logger;
            _mapper = mapper;
            _mediator = mediator;
        }

        public override Task<ResponseMessage> GetUserIndentity(GetRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ResponseMessage());
        }
        public override Task<ResponseMessage> AddUserIndentity(AddRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ResponseMessage());
        }
        public override Task<Empty> UpdateEmail(UpdateEmailRequest request, ServerCallContext context)
        {
            return Task.FromResult(new Empty());
        }
        public override Task<Empty> DeleteUserIndentity(DeleteRequest request, ServerCallContext context)
        {
            return Task.FromResult(new Empty());
        }
    }
}