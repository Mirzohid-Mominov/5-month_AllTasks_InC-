using EduCourse.Application.Common.Courses.Services;
using EduCourse.Application.Common.Identity.Services;
using EduCourse.Domain.Entities;
using EduCourse.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCourse.Infrastructure.Common.Courses.Services
{
    public class CourseProcessingService : ICourseProcessingService
    {
        private readonly ICourseService _courseService;
        private readonly AppDbContext _appDbContext;
        private readonly IUserservice _usersService;

        public CourseProcessingService(ICourseService courseService, AppDbContext appDbContext, IUserservice usersService)
        {
            _courseService = courseService;
            _appDbContext = appDbContext;
            _usersService = usersService;
        }

        public async  ValueTask<bool> AddStudent(Guid CourseId, Guid studentId)
        {
            var course = await _courseService.GetByIdAsync(CourseId) ?? throw new InvalidOperationException("This couse not found");

            course.CourseStudents.Add(new CourseStudent
            {
                StudentId = studentId,
                CourseId = CourseId
            });

            await _appDbContext.SaveChangesAsync();

            return true;
        }
    }
}
