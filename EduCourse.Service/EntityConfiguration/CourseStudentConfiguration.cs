using EduCourse.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCourse.Persistence.EntityConfiguration
{
    public class CourseStudentConfiguration : IEntityTypeConfiguration<CourseStudent>
    {
        public void Configure(EntityTypeBuilder<CourseStudent> builder)
        {
            builder.HasKey(x => new { x.CourseId, x.StudentId });

            builder.HasOne(x => x.Course).WithMany(i => i.CourseStudents).HasForeignKey(x => x.CourseId);

            builder.HasOne(c => c.Student).WithMany(u => u.CourseStudents).HasForeignKey(c => c.StudentId);
        }
    }
}
