using Application.Features.BannedPrompts.Commands.Create;
using Application.Features.BannedPrompts.Commands.Delete;
using Application.Features.BannedPrompts.Commands.Update;
using Application.Features.BannedPrompts.Queries.GetById;
using Application.Features.BannedPrompts.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BannedPromptsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBannedPromptCommand createBannedPromptCommand)
    {
        CreatedBannedPromptResponse response = await Mediator.Send(createBannedPromptCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBannedPromptCommand updateBannedPromptCommand)
    {
        UpdatedBannedPromptResponse response = await Mediator.Send(updateBannedPromptCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedBannedPromptResponse response = await Mediator.Send(new DeleteBannedPromptCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdBannedPromptResponse response = await Mediator.Send(new GetByIdBannedPromptQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListBannedPromptQuery getListBannedPromptQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListBannedPromptListItemDto> response = await Mediator.Send(getListBannedPromptQuery);
        return Ok(response);
    }
}