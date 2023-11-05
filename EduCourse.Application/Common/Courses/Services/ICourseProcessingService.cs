using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCourse.Application.Common.Courses.Services
{
    public interface ICourseProcessingService
    {
        ValueTask<bool> AddStudent(Guid CourseId, Guid studentId);
    }
}
