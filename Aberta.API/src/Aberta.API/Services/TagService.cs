using AbertaApi.Contracts.Repositories;
using AbertaApi.Contracts.Services;
using AbertaApi.Models;
using Serilog;

namespace Aberta.API.Services;

public class TagService(ITagRepository repo, ILogger<TagService> logger) : ITagService
{
    public async Task<ResultWrapper<Tag>> CreateTag(Tag newTag)
    {
        var result = new ResultWrapper<Tag>();

        try
        {
            var oldTag = await repo.GetTag(newTag.Id);
            
            if(oldTag.Data == null)
            {
                var tag = await repo.CreateTag(newTag);
                result.IsSuccessful = true;
                result.Data = tag.Data;
            }
            else
            {
                logger.LogInformation("Tag already exists.");
                result.Errors.Add("Tag already exists");
            }
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }

        logger.LogInformation("Finished creating tag.");
        return result;
    }
    
    public async Task<ResultWrapper<Tag>> GetTag(int id)
    {
        var result = new ResultWrapper<Tag>();

        try
        {
            var tag = await repo.GetTag(id);

            if (tag.IsSuccessful)
            {
                result = tag;
            }
            else
            {
                result.Errors = tag.Errors;
            }
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public ResultWrapper<List<Tag>> GetActiveTags()
    {
        var result = new ResultWrapper<List<Tag>>();

        try
        {
            var tag = repo.GetTags(t => t.IsActive);

            if (tag.IsSuccessful)
            {
                result = tag;
            }
            else
            {
                result.Errors = tag.Errors;
            }
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public ResultWrapper<List<Tag>> GetActiveTags(string name)
    {
        var result = new ResultWrapper<List<Tag>>();

        try
        {
            var tag = repo.GetTags(t => t.IsActive && t.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));

            if (tag.IsSuccessful)
            {
                result = tag;
            }
            else
            {
                result.Errors = tag.Errors;
            }
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public ResultWrapper<List<Tag>> GetInactiveTags()
    {
        var result = new ResultWrapper<List<Tag>>();

        try
        {
            var tag = repo.GetTags(t => !t.IsActive);

            if (tag.IsSuccessful)
            {
                result = tag;
            }
            else
            {
                result.Errors = tag.Errors;
            }
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }
    
    public async Task<ResultWrapper<Tag>> UpdateTag(Tag updateTag)
    {
        var result = new ResultWrapper<Tag>();

        try
        {
            var oldTag = await repo.GetTag(updateTag.Id);

            if(oldTag.Data != null)
            {
                var tag = await repo.UpdateTag(updateTag);
                result.Data = tag.Data;
                result.IsSuccessful = true;
            }
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public async Task<ResultWrapper<Tag>> DeleteTag(int id)
    {
        var result = new ResultWrapper<Tag>();

        try
        {
            var oldTag = await repo.GetTag(id);
            
            if(oldTag.Data != null)
            {
                await repo.DeleteTag(oldTag.Data);
                result.IsSuccessful = true;
            }
        }
        catch (Exception e)
        {
            logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public List<Tag> ValidateTags(List<Tag> tagsList)
    {
        List<Tag> newTagList = [];
        foreach (var tag in tagsList)
        {
            var currentTag = GetActiveTags(tag.Name).Data.FirstOrDefault();

            if (currentTag != null)
            {
                var tags = newTagList.Where(t => string.Equals(t.Name.ToLowerInvariant(), currentTag.Name.ToLowerInvariant()))
                    .ToList();

                if (tags.Count <= 0)
                {
                    newTagList.Add(currentTag);
                }
            }
            else
            {
                newTagList.Add(tag);
            }
        }

        return newTagList;
    }
}