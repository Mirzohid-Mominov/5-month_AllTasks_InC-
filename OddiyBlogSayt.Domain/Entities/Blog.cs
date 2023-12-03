using OddiyBlogSayt.Domain.Common;

namespace OddiyBlogSayt.Domain.Entities;

public class Blog : IEntity
{
    public Guid Id { get; set; }
   
    public string Body { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public Guid AuthorId { get; set; }

    public virtual User Author { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
