using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCourse.Domain.Entities.Courses
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TeacherId { get; set; }
        public Guid CourseId { get; set; }
    }
}
