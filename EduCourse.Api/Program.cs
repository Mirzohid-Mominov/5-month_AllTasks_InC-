
using EduCourse.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);
// builder.Configuration.AddUserSecrets<Program>();
await builder.ConfigureAsync();


var app = builder.Build();
await app.ConfigureAsync();

await app.RunAsync();