using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCourse.Domain.Entities.Courses
{
    public class StudentGroup
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid GrouptId { get; set; }

    }
}
