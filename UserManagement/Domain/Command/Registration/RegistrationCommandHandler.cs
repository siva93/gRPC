using System.Threading;
using System.Threading.Tasks;
using MediatR;
using User.Domain.ViewModel;
using User.Infrastructure.Interface;
using User.Infrastructure.Entity;
using DomainContract.DataContract;
using System;

namespace User.Domain.Command
{
    public class RegistrationCommandHandler : IRequestHandler<RegisterRequest, RegisterResponse>
    {
        private readonly ICommandRepository _commandRepository;
        public RegistrationCommandHandler(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }
        
        public Task<RegisterResponse> Handle(RegisterRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new RegisterResponse(){ UserId = Guid.NewGuid().ToString()});
        }
    }
}