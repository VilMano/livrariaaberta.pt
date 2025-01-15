using AbertaApi.Models;

namespace AbertaApi.Contracts.Repositories;

public interface ITagRepository{
    public Task<ResultWrapper<Tag>> CreateTag(Tag tag);
    public Task<ResultWrapper<Tag>> GetTag(int id);
    public ResultWrapper<List<Tag>> GetTags(Func<Tag, bool> expression);
    public Task<ResultWrapper<Tag>> UpdateTag(Tag tag);
    public Task<ResultWrapper<Tag>> DeleteTag(Tag tag);
}