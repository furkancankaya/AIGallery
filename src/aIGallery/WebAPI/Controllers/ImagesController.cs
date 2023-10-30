using Application.Features.Images.Commands.Create;
using Application.Features.Images.Commands.Delete;
using Application.Features.Images.Commands.Update;
using Application.Features.Images.Queries.GetById;
using Application.Features.Images.Queries.GetList;
 
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ImagesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateImageCommand createImageCommand)
    {
        createImageCommand.UserId = getUserIdFromRequest();
        CreatedImageResponse response = await Mediator.Send(createImageCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateImageCommand updateImageCommand)
    {
        UpdatedImageResponse response = await Mediator.Send(updateImageCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedImageResponse response = await Mediator.Send(new DeleteImageCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdImageResponse response = await Mediator.Send(new GetByIdImageQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListImageQuery getListImageQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListImageListItemDto> response = await Mediator.Send(getListImageQuery);
        return Ok(response);
    }
    [HttpGet("GetListByUserId")]
    public async Task<IActionResult> GetListByUserId([FromQuery] PageRequestWithUserId pageRequest)
    {
    
        GetListImageByUserIdQuery getListImageByUserIdQuery = new() { PageRequestWithUserId = pageRequest };
        GetListResponse<GetListImageListItemDto> response = await Mediator.Send(getListImageByUserIdQuery);
        return Ok(response);
    }
    [HttpGet("GetTopImages")]
    public async Task<IActionResult> GetTopImages([FromQuery] PageRequest pageRequest)
    {

        GetTopImagesQuery getListImageByUserIdQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListImageListItemDto> response = await Mediator.Send(getListImageByUserIdQuery);
        return Ok(response);
    }

}
