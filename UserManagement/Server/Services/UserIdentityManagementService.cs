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
 
        public override async Task<UserIdentityResponse> GetUserIdentity(GetUserIdentityRequest request, ServerCallContext context)
        {
            var getUserIdentityQuery = _mapper.Map<GetUserIdentityQuery>(request);
            var response = await _mediator.Send(getUserIdentityQuery);
            return _mapper.Map<UserIdentityResponse>(response);
        }
        public override async Task<UserIdentityResponse> AddUserIdentity(AddUserIdentityRequest request, ServerCallContext context)
        {
             var addUserIdentityCommand = _mapper.Map<AddUserIdentityCommand>(request);
            var response = await _mediator.Send(addUserIdentityCommand);
            return _mapper.Map<UserIdentityResponse>(response);
        }
        public override async Task<Empty> UpdateEmail(UpdateEmailRequest request, ServerCallContext context)
        {
             var updateEmailCommand = _mapper.Map<UpdateEmailCommand>(request);
            var response = await _mediator.Send(updateEmailCommand);
            return new Empty();
        }
        
        public override async Task<Empty> DeleteUserIdentity(DeleteUserIdentityRequest request, ServerCallContext context)
        {
            var deleteUserIdentity = _mapper.Map<DeleteUserIdentityCommand>(request);
            var response = await _mediator.Send(deleteUserIdentity);
            return new Empty();
        }
    }
}