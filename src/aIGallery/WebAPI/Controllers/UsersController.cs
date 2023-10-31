using Application.Features.Images.Commands.Create;
using Application.Features.Users.Commands.Create;
using Application.Features.Users.Commands.Delete;
using Application.Features.Users.Commands.Update;
using Application.Features.Users.Commands.UpdateFromAuth;
using Application.Features.Users.Queries.GetById;
using Application.Features.Users.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : BaseController
{
    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdUserQuery getByIdUserQuery)
    {
        GetByIdUserResponse result = await Mediator.Send(getByIdUserQuery);
        return Ok(result);
    }

    [HttpGet("GetFromAuth")]
    public async Task<IActionResult> GetFromAuth()
    {
        GetByIdUserQuery getByIdUserQuery = new() { Id = getUserIdFromRequest() };
        GetByIdUserResponse result = await Mediator.Send(getByIdUserQuery);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListUserQuery getListUserQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListUserListItemDto> result = await Mediator.Send(getListUserQuery);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateUserCommand createUserCommand)
    {
        CreatedUserResponse result = await Mediator.Send(createUserCommand);
        return Created(uri: "", result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateUserCommand updateUserCommand)
    {
        updateUserCommand.Id = getUserIdFromRequest();
        UpdatedUserResponse result = await Mediator.Send(updateUserCommand);
        return Ok(result);
    }

    [HttpPut("FromAuth")]
    public async Task<IActionResult> UpdateFromAuth([FromBody] UpdateUserFromAuthCommand updateUserFromAuthCommand)
    {
        updateUserFromAuthCommand.Id = getUserIdFromRequest();
        UpdatedUserFromAuthResponse result = await Mediator.Send(updateUserFromAuthCommand);
        return Ok(result);
    }
    [HttpPut("UpdateFromNewPasswordAuth")]
    public async Task<IActionResult> UpdateFromNewPasswordAuth([FromBody] UpdateUserFromAuthNewPasswordCommand updateUserFromAuthNewPasswordCommand)
    {
        updateUserFromAuthNewPasswordCommand.Id = getUserIdFromRequest();
         
        UpdateUserFromAuthNewPasswordResponse result = await Mediator.Send(updateUserFromAuthNewPasswordCommand);
        return Ok(result);
    }
    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUserCommand deleteUserCommand)
    {
        DeletedUserResponse result = await Mediator.Send(deleteUserCommand);
        return Ok(result);
    }
    [HttpGet("TopCreators")]
    public async Task<IActionResult> TopCreators([FromQuery] PageRequest pageRequest)
    {
        GetTopCreatorsQuery getTopCreatorsQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListUserListItemDto> result = await Mediator.Send(getTopCreatorsQuery);
        return Ok(result);
    }

}
