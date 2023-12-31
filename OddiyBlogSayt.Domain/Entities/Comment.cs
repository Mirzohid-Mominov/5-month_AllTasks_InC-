﻿using OddiyBlogSayt.Domain.Common;

namespace OddiyBlogSayt.Domain.Entities;

public class Comment : IEntity
{
    public Guid Id { get; set; }

    public string Message { get; set; } = string.Empty;

    public Guid UserId {  get; set; }

    public Guid BlogId {  get; set; }

    public virtual User User { get; set; }

    public virtual Blog Blog { get; set; }
}
