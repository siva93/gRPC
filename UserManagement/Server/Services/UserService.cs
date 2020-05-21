// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Grpc.Core;
// using MediatR;
// using Microsoft.Extensions.Logging;
// using User.Domain.Command;
// using User.Domain.Query;
// using UserServiceProto;

// namespace User.Server
// {
//     public class UserService : UserServiceProto.UserService.UserServiceBase
//     {
//         private readonly IMediator _mediator;
//         private readonly ILogger<UserService> _logger;
//         public UserService(ILogger<UserService> logger, IMediator mediator)
//         {
//             _logger = logger;
//             _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
//         }

//         public override async Task<UserResponse> GetUser(GetUserRequest request, ServerCallContext context)
//         {
//             try{
//                 var response = await _mediator.Send(new GetUserByIdQuery() { UserId = request.UserId });
//                 return new UserResponse()
//                 {
//                 User = new UserServiceProto.User()
//                 {
//                     UserId = response.UserId,
//                     UserName = response.UserName,
//                     Age = response.Age,
//                     IsActive = response.IsActive
//                 }
//             };
//             }catch(Exception ex){
//                 _logger.LogError(ex, ex.Message);
//                 return new UserResponse();
//             }
//         }
//         public override Task<AddUserResponse> AddUser(AddUserRequest request, ServerCallContext context)
//         {
//             var response = _mediator.Send(new AddUserCommand() { UserName =  request.UserName, Age = request.Age, Name = request.Name } ).Result;

//             return  Task.FromResult(new AddUserResponse() { UserName = response.UserName, UserId = response.UserId });
//         }
//     }
// }
