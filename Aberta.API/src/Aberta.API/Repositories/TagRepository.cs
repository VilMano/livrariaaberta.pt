using AbertaApi.Contracts.Repositories;
using AbertaApi.Data;
using AbertaApi.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace AbertaApi.Repositories;

public class TagRepository : ITagRepository
{
    private readonly IConfiguration _configuraiton;
    private readonly DbContextOptionsBuilder<Context> _ctxOptions;

    public TagRepository(IConfiguration configuration)
    {
        _configuraiton = configuration;

        var connectionString = _configuraiton.GetConnectionString("Database");
        _ctxOptions = new DbContextOptionsBuilder<Context>().UseMySql(
            connectionString,
            ServerVersion.AutoDetect(connectionString)
        );
    }

    public async Task<ResultWrapper<Tag>> CreateTag(Tag tag)
    {
        Log.Information($"-------------------{tag.Id}------------------------");
        Log.Information("Creating tag...");
        ResultWrapper<Tag> result = new ResultWrapper<Tag>();

        using (var ctx = new Context(_ctxOptions.Options))
        {
            try
            {
                var res = await ctx.Tags.AddAsync(tag);
                await ctx.SaveChangesAsync();
                
                if (res != null)
                {
                    result.Data = res.Entity;
                    result.IsSuccessful = true;

                    Log.Information("Tag created");
                }
                else
                {
                    Log.Error("Tag was not created.");
                    result.Errors.Add("Tag was not created.");
                }
            }
            catch (Exception e)
            {
                result.Errors.Add("Something went wrong.");
                Log.Error(e.Message);
                
                return result;
            }
        }

        return result;
    }

    public async Task<ResultWrapper<Tag>> GetTag(int id)
    {
        Log.Information($"-------------------{id}------------------------");
        Log.Information("Fetching tag...");
        ResultWrapper<Tag> result = new ResultWrapper<Tag>();

        try
        {
            using (var ctx = new Context(_ctxOptions.Options))
            {
                var res = await ctx.Tags.FirstOrDefaultAsync(x => x.Id == id);

                if (res != null)
                {
                    result.Data = res;
                    result.IsSuccessful = true;
                    
                    Log.Information("Tag successfully found.");
                }
                else
                {
                    string error = "No tag was found.";
                    
                    Log.Information(error);
                    result.Errors.Add(error);
                }
            }
        }
        catch (Exception e)
        {
            Log.Error(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public ResultWrapper<List<Tag>> GetTags(Func<Tag, bool> expression)
    {
        Log.Information("Fetching tags...");
        ResultWrapper<List<Tag>> result = new ResultWrapper<List<Tag>>();

        try
        {
            using (var ctx = new Context(_ctxOptions.Options))
            {
                var res = ctx.Tags.Where(expression).ToList();

                if (res != null)
                {
                    result.Data = res;
                    result.IsSuccessful = true;
                    
                    Log.Information("Tags were successfully fetched.");
                }
                else
                {
                    string error = "Tags were not found.";
                    
                    result.Errors.Add(error);
                    Log.Information(error);
                }
            }
        }
        catch (Exception e)
        {
            Log.Error(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public async Task<ResultWrapper<Tag>> UpdateTag(Tag newTag)
    {
        Log.Information($"-------------------{newTag.Name}------------------------");
        Log.Information("Starting update tag...");
        ResultWrapper<Tag> result = new ResultWrapper<Tag>();

        try
        {
            using (var ctx = new Context(_ctxOptions.Options))
            {
                var res = ctx.Tags.Update(newTag);
                await ctx.SaveChangesAsync();

                if (res != null)
                {
                    result.Data = res.Entity;
                    result.IsSuccessful = true;
                    
                    Log.Information("Tag updated");
                }
                else
                {
                    Log.Error("Tag was not updated.");
                }
            }
        }
        catch (Exception e)
        {
            Log.Error(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }

    public async Task<ResultWrapper<Tag>> DeleteTag(Tag tag)
    {
        Log.Information($"-------------------{tag.Name}------------------------");
        Log.Information("Deleting tag...");
        ResultWrapper<Tag> result = new ResultWrapper<Tag>();

        try
        {
            using (var ctx = new Context(_ctxOptions.Options))
            {
                ctx.Tags.Remove(tag);
                await ctx.SaveChangesAsync();
                
                result.IsSuccessful = true;
                Log.Information("Tag successfully deleted.");
            }
        }
        catch (Exception e)
        {
            Log.Error(e.Message);
            result.Errors.Add("Something went wrong.");
        }

        return result;
    }
}