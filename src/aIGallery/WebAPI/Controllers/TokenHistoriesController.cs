using Application.Features.TokenHistories.Commands.Create;
using Application.Features.TokenHistories.Commands.Delete;
using Application.Features.TokenHistories.Commands.Update;
using Application.Features.TokenHistories.Queries.GetById;
using Application.Features.TokenHistories.Queries.GetList;
using Application.Features.Users.Commands.UpdateFromAuth;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TokenHistoriesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateTokenHistoryCommand createTokenHistoryCommand)
    {
        createTokenHistoryCommand.UserId = getUserIdFromRequest();
        

        CreatedTokenHistoryResponse response = await Mediator.Send(createTokenHistoryCommand);



        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateTokenHistoryCommand updateTokenHistoryCommand)
    {
        UpdatedTokenHistoryResponse response = await Mediator.Send(updateTokenHistoryCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedTokenHistoryResponse response = await Mediator.Send(new DeleteTokenHistoryCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdTokenHistoryResponse response = await Mediator.Send(new GetByIdTokenHistoryQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListTokenHistoryQuery getListTokenHistoryQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListTokenHistoryListItemDto> response = await Mediator.Send(getListTokenHistoryQuery);
        return Ok(response);
    }
}