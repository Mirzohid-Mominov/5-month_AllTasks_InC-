using OddiyBlogSayt.Domain.Common;
using System.Text.Json.Serialization;

namespace OddiyBlogSayt.Domain.Entities;

public class User : IEntity
{
    public Guid Id { get; set; }    

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string EmailAddress { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    [JsonIgnore]
    public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();

    [JsonIgnore]
    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
