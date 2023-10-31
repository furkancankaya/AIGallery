
using Application.Features.Images.Rules;
using MediatR;
using Application.Features.Auth.Commands.Login;

namespace Application.Features.Images.Commands.Create;

public class AreBlockedCommand : IRequest<AreBlockedResponse>
{
    public int UserId { get; set; }

    public class AreBlockedCommandHandler : IRequestHandler<AreBlockedCommand, AreBlockedResponse>
    {
        private readonly ImageBusinessRules _imageBusinessRules;

        public AreBlockedCommandHandler(ImageBusinessRules imageBusinessRules)
        {
            _imageBusinessRules = imageBusinessRules;
        }

      
        public async Task<AreBlockedResponse> Handle(AreBlockedCommand request, CancellationToken cancellationToken)
        {
           
            AreBlockedResponse response = new AreBlockedResponse { status = true };
            await _imageBusinessRules.AreBlocked(request.UserId);
            return response;
        }

    }
}