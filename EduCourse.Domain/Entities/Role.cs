﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCourse.Domain.Entities
{
    public class Role
    {
        public Guid UserId { get; set; }

        public string Name { get; set; } = default!;
    }
}
