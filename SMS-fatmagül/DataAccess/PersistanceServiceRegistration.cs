using DataAccess.Abstracts;
using DataAccess.Concrete;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public static class PersistanceServiceRegistration
{
    public static IServiceCollection AddPersistenceServis(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(
            
            configuration.GetConnectionString("BaseDb")
            ));//.UseInMemoryDatabase. dersek veri tabanı olmadan çalışır ama veri tabanını göremeyiz
        services.AddScoped<IStudentDal, EfStudentDal>()
                 .AddScoped<IInstructorDal, EfInstructorDal>()
                 .AddScoped<ICourseDal, EfCourseDal>()
                 .AddScoped<ICourseStudentDal, EfCourseStudentDal>();
        return services;
    }
}
