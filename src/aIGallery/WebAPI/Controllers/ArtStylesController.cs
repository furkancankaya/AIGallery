using Application.Features.ArtStyles.Commands.Create;
using Application.Features.ArtStyles.Commands.Delete;
using Application.Features.ArtStyles.Commands.Update;
using Application.Features.ArtStyles.Queries.GetById;
using Application.Features.ArtStyles.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArtStylesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateArtStyleCommand createArtStyleCommand)
    {
        CreatedArtStyleResponse response = await Mediator.Send(createArtStyleCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateArtStyleCommand updateArtStyleCommand)
    {
        UpdatedArtStyleResponse response = await Mediator.Send(updateArtStyleCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedArtStyleResponse response = await Mediator.Send(new DeleteArtStyleCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdArtStyleResponse response = await Mediator.Send(new GetByIdArtStyleQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListArtStyleQuery getListArtStyleQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListArtStyleListItemDto> response = await Mediator.Send(getListArtStyleQuery);
        return Ok(response);
    }
}