using AbertaApi.Contracts.Repositories;
using AbertaApi.Data;
using AbertaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Aberta.API.Repositories;

public class TagRepository : ITagRepository
{
    private readonly IConfiguration _configuraiton;
    private readonly Context _context;
    private readonly ILogger<TagRepository> _logger;

    public TagRepository(IConfiguration configuration, ILogger<TagRepository> logger)
    {
        _configuraiton = configuration;
        _context = new Context(_configuraiton.GetConnectionString("Database"));
        _logger = logger;
    }

    public async Task<ResultWrapper<Tag>> CreateTag(Tag tag)
    {
        _logger.LogInformation("Creating tag...");
        var result = new ResultWrapper<Tag>();

        try
        {
            var res = await _context.Tags.AddAsync(tag);
            await _context.SaveChangesAsync();

            if (res != null)
            {
                result.Data = res.Entity;
                result.IsSuccessful = true;

                _logger.LogInformation("Tag created");
            }
            else
            {
                _logger.LogError("Tag was not created.");
                result.Errors.Add("Tag was not created.");
            }
        }
        catch (Exception e)
        {
            result.Errors.Add("Something went wrong.");
            _logger.LogError(e.Message, e);

            return result;
        }

        return result;
    }

    public async Task<ResultWrapper<Tag>> GetTag(int id)
    {
        _logger.LogInformation("Fetching tag...");
        var result = new ResultWrapper<Tag>();

        try
        {
            var res = await _context.Tags.FirstOrDefaultAsync(x => x.Id == id);

            if (res != null)
            {
                result.Data = res;
                result.IsSuccessful = true;

                _logger.LogInformation("Tag successfully found.");
            }
            else
            {
                const string error = "No tag was found.";

                _logger.LogError(error);
                result.Errors.Add(error);
            }
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public ResultWrapper<List<Tag>> GetTags(Func<Tag, bool> expression)
    {
        _logger.LogInformation("Fetching tags...");
        var result = new ResultWrapper<List<Tag>>();

        try
        {
            var res = _context.Tags.Where(expression).ToList();

            if (res != null)
            {
                result.Data = res;
                result.IsSuccessful = true;

                _logger.LogInformation("Tags were successfully fetched.");
            }
            else
            {
                const string error = "Tags were not found.";

                result.Errors.Add(error);
                _logger.LogError(error);
            }
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public async Task<ResultWrapper<Tag>> UpdateTag(Tag newTag)
    {
        _logger.LogInformation("Starting update tag...");
        var result = new ResultWrapper<Tag>();

        try
        {
            var res = _context.Tags.Update(newTag);
            await _context.SaveChangesAsync();

            if (res != null)
            {
                result.Data = res.Entity;
                result.IsSuccessful = true;

                _logger.LogInformation("Tag updated");
            }
            else
            {
                _logger.LogError("Tag was not updated.");
            }
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public async Task<ResultWrapper<Tag>> DeleteTag(Tag tag)
    {
        _logger.LogInformation("Deleting tag...");
        var result = new ResultWrapper<Tag>();

        try
        {
            _context.Tags.Remove(tag);
            await _context.SaveChangesAsync();

            result.IsSuccessful = true;
            _logger.LogInformation("Tag successfully deleted.");
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message, e);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }
}