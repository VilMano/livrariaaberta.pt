using AbertaApi.Contracts.Services;
using AbertaApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aberta.API.Controllers;

[Route("[controller]")]
public class TagController (ITagService tagService) : ControllerBase
{
    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpGet("single")]
    public async Task<IActionResult> GetTag(int id)
    {
        var result = await tagService.GetTag(id);

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result.Errors);
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpGet("all/inactive")]
    public IActionResult GetInactiveTags()
    {
        var result = tagService.GetInactiveTags();

        if (result.IsSuccessful)
        {
            return Ok(result);
        }

        return BadRequest(result.Errors);
    }
    
    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpGet("all/active")]
    public IActionResult GetActiveTags()
    {
        var result = tagService.GetActiveTags();

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
        var result = await tagService.CreateTag(newTag);

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
        var result = await tagService.UpdateTag(updatedTag);

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
        var result = await tagService.DeleteTag(id);

        if (result.IsSuccessful)
        {
            return Ok(result.Data);
        }

        return BadRequest(result.Errors);
    }
}