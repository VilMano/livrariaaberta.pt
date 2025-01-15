using Aberta.API.Contracts.Services;
using AbertaApi.Models;
using ImageMagick;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Aberta.API.Services;

public class ImageService(IConfiguration config) : IImageService
{
    public ResultWrapper<Byte[]> GetImage(string imageName)
    {
        ResultWrapper<Byte[]> result = new ResultWrapper<Byte[]>();
        
        string folderPath = config.GetValue<string>("ImagesPath");
        
        string basePath = "";
        string filePath = "";
        if (imageName.Contains("-c"))
        {
            string fullImageName = imageName.Split("-")[0];
            filePath = Path.Combine(folderPath, $"{fullImageName}/{fullImageName}.jpg");
        }
        else
        {
            filePath = Path.Combine(folderPath, $"{imageName}/{imageName}.jpg");
        }

        if (File.Exists(filePath))
        {
            result.IsSuccessful = true;
        }

        result.Data = File.ReadAllBytes(filePath);

        return result;
    }
    
    public async Task<ResultWrapper<Byte[]>> HandleImageCreation(IFormFile file)
    {
        ResultWrapper<Byte[]> result = new ResultWrapper<Byte[]>();
        
        string imageDirectory = config.GetValue<string>("ImagesPath");
        string isbn = file.FileName.Split(".")[0];
        string fileType = file.FileName.Split(".")[1];
        
        string filePath = Path.Combine(imageDirectory, isbn + "/" + file.FileName);
        string filePathCompressed = Path.Combine(imageDirectory, $"{isbn}/{isbn}-c.{fileType}");

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            File.Delete(filePathCompressed);
        }
        
        Directory.CreateDirectory(imageDirectory+ $"/{isbn}");
        
        
        // create image
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }
        
        // create image copy
        using (var stream = new FileStream(filePathCompressed, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }
        
        CompressImage(filePathCompressed);
        
        if (File.Exists(filePath) && File.Exists(filePathCompressed))
        {
            result.IsSuccessful = true;
            result.Data = GetImage(isbn).Data;
        }

        return result;
    }

    public async Task CompressImage(string filePath)
    {
        if (File.Exists(filePath))
        {
            var uncompressedImage = new FileInfo(filePath);

            var optimizer = new ImageOptimizer();
            optimizer.LosslessCompress(uncompressedImage);

            uncompressedImage.Refresh();
        }
    }
    
    public ResultWrapper<bool> DeleteImage(string path)
    {
        ResultWrapper<bool> result = new ResultWrapper<bool>();
        
        string imageDirectory = config.GetValue<string>("ImagesPath");

        string isbn = path.Split(".")[0];
        string fileExt = path.Split(".")[1];
        
        string fullPath = $"{imageDirectory}/{isbn}/{isbn}.{fileExt}";
        string fullPathCompressed = $"{imageDirectory}/{isbn}/{isbn}-c.{fileExt}";

        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }
        
        if (File.Exists(fullPathCompressed))
        {
            File.Delete(fullPathCompressed);
        }

        if (!File.Exists(fullPathCompressed) && !File.Exists(fullPath))
        {
            result.IsSuccessful = true;
        }

        return result;
    }
}