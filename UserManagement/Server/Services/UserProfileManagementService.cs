namespace User.Server.Services
{
    using UserProfile;
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
    public class UserProfileManagementService : UserProfile.UserProfileBase
    {
        private readonly ILogger<UserProfileManagementService> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public UserProfileManagementService(ILogger<UserProfileManagementService> logger, IMapper mapper, IMediator mediator)
        {
            _logger = logger;
            _mapper = mapper;
            _mediator = mediator;
        }

        public override Task<UserProfileResponse> GetUserProfile(GetUserProfileRequest request, ServerCallContext context)
        {
            return Task.FromResult(new UserProfileResponse());
        }

        public override Task<Empty> UpdateUserProfile(UpdateUserProfileRequest request, ServerCallContext context)
        {
            return Task.FromResult(new Empty());
        }
        public override Task<UserProfileResponse> CreateUserProfile(CreateUserProfileRequest request, ServerCallContext context)
        {
            return Task.FromResult(new UserProfileResponse());
        }
    }
}