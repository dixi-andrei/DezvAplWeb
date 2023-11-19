using Lab4.Helpers.Seeders;
using Lab4.Models;
using Lab4.Repository.StudentRepository;

using Lab4.Services;

namespace Lab4.Helpers.Extensions

{
    public static class ServiceExtentions
    {
        public static IServiceCollection AddStudentServices(this IServiceCollection services)
        {
            
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<StudentService>();

       
            services.AddTransient<StudentSeeder>();

            return services;
        }

    }
}
