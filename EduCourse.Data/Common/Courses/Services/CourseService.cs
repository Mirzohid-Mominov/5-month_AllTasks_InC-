using EduCourse.Application.Common.Courses.Services;
using EduCourse.Domain.Entities;
using EduCourse.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCourse.Infrastructure.Common.Courses.Services
{
    public class CourseService : ICourseService
    {
        private readonly AppDbContext _appDbContext;

        public CourseService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async ValueTask<Course?> GetByIdAsync(Guid courseId, CancellationToken cancellation = default)
        {
            var user = await _appDbContext.Courses
                .Include(course => course.CourseStudents)
                .FirstOrDefaultAsync(course => course.Id == courseId, cancellationToken: cancellation);

            return user;
        }
    }
}
