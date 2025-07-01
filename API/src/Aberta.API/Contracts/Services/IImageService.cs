using AbertaApi.Models;

namespace Aberta.API.Contracts.Services;

public interface IImageService
{
    public ResultWrapper<Byte[]> GetImage(string imageName);
    public Task<ResultWrapper<Byte[]>> HandleImageCreation(IFormFile file);

    public ResultWrapper<bool> DeleteImage(string path);
}