using AbertaApi.Contracts.Repositories;
using AbertaApi.Contracts.Services;
using AbertaApi.Models;
using Serilog;

namespace Aberta.API.Services;

public class TagService(IConfiguration config, ITagRepository repo) : ITagService
{
    private readonly IConfiguration _config = config;

    public async Task<ResultWrapper<Tag>> CreateTag(Tag newTag)
    {
        ResultWrapper<Tag> result = new ResultWrapper<Tag>();

        try
        {
            var oldTag = await repo.GetTag(newTag.Id);
            
            if(oldTag.Data == null)
            {
                ResultWrapper<Tag> tag = await repo.CreateTag(newTag);
                result.IsSuccessful = true;
                result.Data = tag.Data;
            }
            else
            {
                result.Errors.Add("Tag already exists");
            }
        }
        catch (Exception e)
        {
            Log.Information(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }
    
    public async Task<ResultWrapper<Tag>> GetTag(int id)
    {
        ResultWrapper<Tag> result = new ResultWrapper<Tag>();

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
            Log.Information(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public ResultWrapper<List<Tag>> GetActiveTags()
    {
        ResultWrapper<List<Tag>> result = new ResultWrapper<List<Tag>>();

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
            Log.Information(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public ResultWrapper<List<Tag>> GetActiveTags(string name)
    {
        ResultWrapper<List<Tag>> result = new ResultWrapper<List<Tag>>();

        try
        {
            var tag = repo.GetTags(t => t.IsActive && t.Name.ToLowerInvariant() == name.ToLowerInvariant());

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
            Log.Information(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public ResultWrapper<List<Tag>> GetInactiveTags()
    {
        ResultWrapper<List<Tag>> result = new ResultWrapper<List<Tag>>();

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
            Log.Information(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }
    
    public async Task<ResultWrapper<Tag>> UpdateTag(Tag updateTag)
    {
        ResultWrapper<Tag> result = new ResultWrapper<Tag>();

        try
        {
            var oldTag = await repo.GetTag(updateTag.Id);
            
            ResultWrapper<Tag> tag;
            if(oldTag.Data != null)
            {
                tag = await repo.UpdateTag(updateTag);
                result.Data = tag.Data;
                result.IsSuccessful = true;
            }
        }
        catch (Exception e)
        {
            Log.Information(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public async Task<ResultWrapper<Tag>> DeleteTag(int id)
    {
        ResultWrapper<Tag> result = new ResultWrapper<Tag>();

        try
        {
            var oldTag = await repo.GetTag(id);
            ResultWrapper<Tag> tag;
            
            if(oldTag.Data != null)
            {
                tag = await repo.DeleteTag(oldTag.Data);
                result.IsSuccessful = true;
            }
        }
        catch (Exception e)
        {
            Log.Information(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }
}