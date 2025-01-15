using AbertaApi.Contracts.Services;
using AbertaApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AbertaApi.Controllers;

public class TagController (ITagService tagService) : ControllerBase
{
    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpGet("single")]
    public async Task<IActionResult> GetTag(int id)
    {
        ResultWrapper<Tag> result = await tagService.GetTag(id);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result.Errors);
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpGet("all/inactive")]
    public async Task<IActionResult> GetInactiveTags()
    {
        ResultWrapper<List<Tag>> result = tagService.GetInactiveTags();

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result.Errors);
    }
    
    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpGet("all/active")]
    public async Task<IActionResult> GetActiveTags()
    {
        ResultWrapper<List<Tag>> result = tagService.GetActiveTags();

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result.Errors);
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpPost("create")]
    public async Task<IActionResult> CreateTag(Tag newTag)
    {
        var a = await tagService.CreateTag(newTag);
        ResultWrapper<Tag> result = a;

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result.Errors);
    }
    
    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpPost("update")]
    public async Task<IActionResult> UpdateTag(Tag updatedTag)
    {
        ResultWrapper<Tag> result = await tagService.UpdateTag(updatedTag);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result.Errors);
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpPost("remove")]
    public async Task<IActionResult> DeleteTag(int id)
    {
        ResultWrapper<Tag> result = await tagService.DeleteTag(id);

        if (result.IsSuccessful)
        {
            return Ok(result.Data);
        }

        return BadRequest(result.Errors);
    }
}