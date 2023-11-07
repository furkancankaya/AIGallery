using Application.Features.Images.Commands.Create;
using Application.Features.Pros.Commands.Create;
using Application.Features.Pros.Commands.Delete;
using Application.Features.Pros.Commands.Update;
using Application.Features.Pros.Queries.GetById;
using Application.Features.Pros.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateProCommand createProCommand)
    {
        createProCommand.UserId = getUserIdFromRequest();
        CreatedProResponse response = await Mediator.Send(createProCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProCommand updateProCommand)
    {
        UpdatedProResponse response = await Mediator.Send(updateProCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedProResponse response = await Mediator.Send(new DeleteProCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdProResponse response = await Mediator.Send(new GetByIdProQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListProQuery getListProQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListProListItemDto> response = await Mediator.Send(getListProQuery);
        return Ok(response);
    }
}