using Application.Features.Likes.Commands.Create;
using Application.Features.Likes.Commands.Delete;
using Application.Features.Likes.Commands.Update;
using Application.Features.Likes.Queries.GetById;
using Application.Features.Likes.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LikesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLikeCommand createLikeCommand)
    {
        CreatedLikeResponse response = await Mediator.Send(createLikeCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLikeCommand updateLikeCommand)
    {
        UpdatedLikeResponse response = await Mediator.Send(updateLikeCommand);

        return Ok(response);
    }

    [HttpPost("UnLike")]
    public async Task<IActionResult> Delete([FromBody] DeleteLikeCommand request)
    {
        DeletedLikeResponse response = await Mediator.Send(request);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdLikeResponse response = await Mediator.Send(new GetByIdLikeQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequestWithUserId pageRequestWithUserId)
    {
        GetListLikeQuery getListLikeQuery = new() { PageRequestWithUserId = pageRequestWithUserId };
        GetListResponse<GetListLikeListItemDto> response = await Mediator.Send(getListLikeQuery);
        return Ok(response);
    }
 

    
}