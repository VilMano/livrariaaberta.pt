using Aberta.API.Contracts.Services;
using AbertaApi.Models;
using ImageMagick;

namespace Aberta.API.Services;

public class ImageService(IConfiguration config, ILogger<ImageService> logger) : IImageService
{
    public ResultWrapper<byte[]> GetImage(string imageName)
    {
        logger.LogInformation("Getting image...");
        var result = new ResultWrapper<byte[]>();
        var filePath = "";
        var folderPath = config.GetValue<string>("ImagesPath");
        
        if (string.IsNullOrEmpty(folderPath)){ logger.LogError("Folder path is empty"); return result; }
        
        
        var imageNameNoExtension = imageName.Contains('-') ? imageName.Split("-")[0] : imageName.Split(".")[0];
        
        var dirPath = Path.Combine(folderPath, imageNameNoExtension);
        string[] files = [];
        if(Directory.Exists(dirPath))
        {
            files = Directory.GetFiles(dirPath);
            
            filePath = imageName.Contains('-') ? files.First(f => f.Contains('-')) : files.First(f => !f.Contains('-'));

            if (!File.Exists(filePath))
            {
                logger.LogInformation("Finished getting image, with no results.");
                return result;
            }
            
            result.IsSuccessful = true;
            result.Data = File.ReadAllBytes(filePath);
        }


        logger.LogInformation("Finished getting image.");
        return result;
    }
    
    public async Task<ResultWrapper<byte[]>> HandleImageCreation(IFormFile file)
    {
        logger.LogInformation("Creating image...");
        var result = new ResultWrapper<byte[]>();
        
        var imageDirectory = config.GetValue<string>("ImagesPath");
        if (string.IsNullOrEmpty(imageDirectory)) return result;
        
        var isbn = file.FileName.Split(".")[0];
        var fileType = file.FileName.Split(".")[1];
        
        var filePath = Path.Combine(imageDirectory, isbn + "/" + file.FileName);
        var filePathCompressed = Path.Combine(imageDirectory, $"{isbn}/{isbn}-c.{fileType}");

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            File.Delete(filePathCompressed);
        }
        
        Directory.CreateDirectory(imageDirectory+ $"/{isbn}");
        
        
        // create image
        await using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }
        
        // create image copy
        await using (var stream = new FileStream(filePathCompressed, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }
        
        CompressImage(filePathCompressed);

        if (!File.Exists(filePath) || !File.Exists(filePathCompressed))
        {
            logger.LogInformation("Finished creating image with no results.");    
            return result;
        }
        
        result.IsSuccessful = true;
        result.Data = GetImage(isbn).Data;

        logger.LogInformation("Finished creating image.");
        return result;
    }

    private static void CompressImage(string filePath)
    {
        if (!File.Exists(filePath)) return;
        
        var uncompressedImage = new FileInfo(filePath);

        var optimizer = new ImageOptimizer();
        optimizer.LosslessCompress(uncompressedImage);

        uncompressedImage.Refresh();
    }
    
    public ResultWrapper<bool> DeleteImage(string path)
    {
        logger.LogInformation("Deleting image...");
        var result = new ResultWrapper<bool>();
        
        var imageDirectory = config.GetValue<string>("ImagesPath");

        var isbn = path.Split(".")[0];
        var fileExt = path.Split(".")[1];
        
        var fullPath = $"{imageDirectory}/{isbn}/{isbn}.{fileExt}";
        var fullPathCompressed = $"{imageDirectory}/{isbn}/{isbn}-c.{fileExt}";

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
            
            logger.LogInformation("Finished deleting image.");
            return result;
        }

        logger.LogInformation("Unable to delete image.");
        return result;
    }
}