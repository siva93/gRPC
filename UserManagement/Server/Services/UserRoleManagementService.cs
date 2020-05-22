namespace User.Server.Services
{
    using UserRole;
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

    public class UserRoleManagementService : UserRole.UserRoleBase
    {
        private readonly ILogger<UserRoleManagementService> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UserRoleManagementService(ILogger<UserRoleManagementService> logger, IMapper mapper, IMediator mediator)
        {
            _logger = logger;
            _mapper = mapper;
            _mediator = mediator;
        }

        public override async Task<UserRoleResponse> GetUserRole(GetUserRoleRequest request, ServerCallContext context)
        {
            var getUserRoleQuery = _mapper.Map<GetUserRoleQuery>(request);
            var response = await _mediator.Send(getUserRoleQuery);
            return _mapper.Map<UserRoleResponse>(response);
        }
        public override async Task<Empty> UpdateUserRole(UpdateUserRoleRequest request, ServerCallContext context)
        {
            var updateUserRoleCommand = _mapper.Map<UpdateUserRoleCommand>(request);
            var response = await _mediator.Send(updateUserRoleCommand);
            return new Empty();
        }
    }
}