using Business.Abstracts;
using Business.Concretes;
using Entities.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business;

public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddScoped<IStudentService, StudentManager>()
                 .AddScoped<IInstructorService, InstructorManager>()
                 .AddScoped<ICourseService, CourseManager>()
                 .AddScoped<ICourseStudentService, CourseStudentManager>();
        return services;

    }
}
