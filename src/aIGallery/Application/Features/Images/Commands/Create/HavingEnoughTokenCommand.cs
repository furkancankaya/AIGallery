
using Application.Features.Images.Rules;
using MediatR;
using Application.Features.Auth.Commands.Login;

namespace Application.Features.Images.Commands.Create;

public class HavingEnoughTokenCommand : IRequest<HavingEnoughTokenResponse>
{
    public int UserId { get; set; }

    public class HavingEnoughTokenCommandHandler : IRequestHandler<HavingEnoughTokenCommand, HavingEnoughTokenResponse>
    {
        private readonly ImageBusinessRules _imageBusinessRules;

        public HavingEnoughTokenCommandHandler(ImageBusinessRules imageBusinessRules)
        {
            _imageBusinessRules = imageBusinessRules;
        }

      
        public async Task<HavingEnoughTokenResponse> Handle(HavingEnoughTokenCommand request, CancellationToken cancellationToken)
        {

            HavingEnoughTokenResponse response = new HavingEnoughTokenResponse { status = true };
            await _imageBusinessRules.HavingEnoughToken(request.UserId);
            return response;
        }

    }
}