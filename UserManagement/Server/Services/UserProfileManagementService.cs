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

        public override async Task<UserProfileResponse> GetUserProfile(GetUserProfileRequest request, ServerCallContext context)
        {
            var getUserProfileQuery = _mapper.Map<GetUserProfileQuery>(request);
            var response = await _mediator.Send(getUserProfileQuery);
            return _mapper.Map<UserProfileResponse>(response);
        }

        public override async Task<Empty> UpdateUserProfile(UpdateUserProfileRequest request, ServerCallContext context)
        {
            var updateUserProfileCommand = _mapper.Map<UpdateUserProfileCommand>(request);
            var response = await _mediator.Send(updateUserProfileCommand);
            return new Empty();
        }
        public override async Task<UserProfileResponse> CreateUserProfile(CreateUserProfileRequest request, ServerCallContext context)
        {
            var createUserProfileCommand = _mapper.Map<CreateUserProfileCommand>(request);
            var response = await _mediator.Send(createUserProfileCommand);
            return _mapper.Map<UserProfileResponse>(response);
        }
    }
}