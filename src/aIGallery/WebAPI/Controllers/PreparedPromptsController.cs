using Application.Features.PreparedPrompts.Commands.Create;
using Application.Features.PreparedPrompts.Commands.Delete;
using Application.Features.PreparedPrompts.Commands.Update;
using Application.Features.PreparedPrompts.Queries.GetById;
using Application.Features.PreparedPrompts.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PreparedPromptsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePreparedPromptCommand createPreparedPromptCommand)
    {
        CreatedPreparedPromptResponse response = await Mediator.Send(createPreparedPromptCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePreparedPromptCommand updatePreparedPromptCommand)
    {
        UpdatedPreparedPromptResponse response = await Mediator.Send(updatePreparedPromptCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedPreparedPromptResponse response = await Mediator.Send(new DeletePreparedPromptCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdPreparedPromptResponse response = await Mediator.Send(new GetByIdPreparedPromptQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListPreparedPromptQuery getListPreparedPromptQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListPreparedPromptListItemDto> response = await Mediator.Send(getListPreparedPromptQuery);
        return Ok(response);
    }
}