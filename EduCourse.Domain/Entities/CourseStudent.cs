using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCourse.Domain.Entities
{
    public class CourseStudent
    {
        public Guid CourseId { get; set; }

        public Guid StudentId { get; set; }

        public virtual Course Course { get; set; }

        public virtual User Student { get; set; }

    }
}
