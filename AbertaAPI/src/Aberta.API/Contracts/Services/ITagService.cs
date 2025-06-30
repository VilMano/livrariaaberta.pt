using AbertaApi.Models;

namespace AbertaApi.Contracts.Services;

public interface ITagService
{
    public Task<ResultWrapper<Tag>> GetTag(int id);
    public ResultWrapper<List<Tag>> GetInactiveTags();
    public ResultWrapper<List<Tag>> GetActiveTags();
    public ResultWrapper<List<Tag>> GetActiveTags(string name);
    public Task<ResultWrapper<Tag>> DeleteTag(int id);
    public Task<ResultWrapper<Tag>> UpdateTag(Tag updateTag);
    public Task<ResultWrapper<Tag>> CreateTag(Tag newTag);
    public List<Tag> ValidateTags(List<Tag> tagsList);
}