using AbertaApi.Models;

namespace Aberta.Tests.Content;

public class Tags
{
    public static List<Tag> GetTags() => new List<Tag>()
    {
        new Tag()
        {
            Id = 1,
            Name = "Drama",
            IsActive = true
        },
        new Tag()
        {
            Id = 2,
            Name = "Policial",
            IsActive = true
        },
        new Tag()
        {
            Id = 3,
            Name = "Romance",
            IsActive = true
        }
    };
}