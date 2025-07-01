using Aberta.API.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aberta.API.Controllers;

[Route("[controller]")]
public class ImageController(IImageService vs) : ControllerBase
{
    [HttpGet("{imageName}")]
    public IActionResult GetBookImage(string imageName)
    {
        var result = vs.GetImage(imageName);

        if (result.IsSuccessful)
        {
            return File(result.Data, "image/jpeg");
        }

        return BadRequest();
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpPost("create")]
    public async Task<IActionResult> CreateBookImage([FromForm] IFormFile file)
    {
        var result = await vs.HandleImageCreation(file);

        if (result.IsSuccessful)
        {
            return Ok(result.Data);
        }
        
        return BadRequest();
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpDelete("delete")]
    public IActionResult DeleteBookImage(string path)
    {
        var result = vs.DeleteImage(path);

        if (result.IsSuccessful)
            return Ok();
        
        return BadRequest();
    }
}