using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EduCourse.Domain.Entities
{
    public class CourseStudent
    {
        public Guid CourseId { get; set; }

        public Guid StudentId { get; set; }

        [JsonIgnore]
        public virtual Course Course { get; set; }
        [JsonIgnore]
        public virtual User Student { get; set; }

    }
}
