using KseniaViktorovaKt_41_20.Interfaces.StudentsInterfaces;

namespace KseniaViktorovaKt_41_20.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            return services;
        }
    }
}
