using EduCourse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCourse.Application.Common.Courses.Services
{
    public interface ICourseService
    {
        ValueTask<Course?> GetByIdAsync(Guid courseId, CancellationToken cancellation = default);
    }
}
