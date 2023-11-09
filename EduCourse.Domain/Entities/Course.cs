using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EduCourse.Domain.Entities
{
    public class Course
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = default!;

        public string? Description { get; set; }
        [JsonIgnore]
        public Guid TeacherId { get; set; }
        [JsonIgnore]
        public virtual User Teacher { get; set; }
        [JsonIgnore]
        public virtual ICollection<CourseStudent> CourseStudents { get; set; }
    }
}
