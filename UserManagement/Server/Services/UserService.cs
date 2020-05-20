using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using UserServiceProto;

namespace User.Server
{
    public class UserService : UserServiceProto.UserService.UserServiceBase
    {
        private readonly ILogger<UserService> _logger;
        public UserService(ILogger<UserService> logger)
        {
            _logger = logger;
        }

        public override Task<UserResponse> GetUser(GetUserRequest request, ServerCallContext context)
        {
            return Task.FromResult(new UserResponse());
        }
        public override Task<UserListResponse> GetUserList(Empty request, ServerCallContext context)
        {
            return Task.FromResult(new UserListResponse());
        }
    }
}
