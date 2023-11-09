using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificationCode.Models;

public enum VerificationType
{
    Email,
    PhoneNumber
}

public class VerificationToken
{
    public Guid UserId { get; set; }

    public DateTimeOffset ExpireTime { get; set; }

    public VerificationType Type { get; set; }
}
