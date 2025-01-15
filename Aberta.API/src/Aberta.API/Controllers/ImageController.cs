using Aberta.API.Contracts.Services;
using AbertaApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AbertaApi.Controllers;

[Authorize(AuthenticationSchemes = "ApiKey")]
[Route("[controller]")]
public class ImageController : ControllerBase
{
    private readonly IImageService _vs;

    public ImageController(IImageService vs)
    {
        _vs = vs;
    }

    [HttpGet("{imageName}")]
    public async Task<IActionResult> GetBookImage(string imageName)
    {
        ResultWrapper<Byte[]> result = _vs.GetImage(imageName);

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
        ResultWrapper<Byte[]> result = await _vs.HandleImageCreation(file);

        if (result.IsSuccessful)
        {
            return Ok(result.Data);
        }
        
        return BadRequest();
    }

    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteBookImage(string path)
    {
        ResultWrapper<bool> result = _vs.DeleteImage(path);

        if (result.IsSuccessful)
            return Ok();
        
        return BadRequest();
    }
}