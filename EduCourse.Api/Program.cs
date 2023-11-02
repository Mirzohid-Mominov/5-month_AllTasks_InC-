using EduCourse.Domain.Entities.Users;

namespace EduCourse.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}